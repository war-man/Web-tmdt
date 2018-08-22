﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels;
using BLL.BLL.CM;
using BLL.BLL.PM;
using BLL.BLL.SM;
using BLL.BLL.SM.Implement;
using DAL.Model.CM;
using DAL.Model.SM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Aoo.Controllers.Admin.SM
{
    [Area("SM")]
    public class SaleOrderController : BaseController
    {
        ISaleOrderBLL ISaleOrderBLL;
        ISaleOrderDetailsBLL ISaleOrderDetailsBLL;
        IProductDetailsBLL IProductDetailsBLL;
        IProductBLL IProductBLL;
        ICustomerBLL ICustomerBLL;
        public SaleOrderController(IProductBLL ProductBLL, IProductDetailsBLL ProductDetailsBLL, ISaleOrderBLL SaleOrderBLL, ISaleOrderDetailsBLL SaleOrderDetailsBLL, ICustomerBLL CustomerBLL)
        {
            this.ISaleOrderDetailsBLL = SaleOrderDetailsBLL;
            this.ISaleOrderBLL = SaleOrderBLL;
            this.ISaleOrderDetailsBLL = SaleOrderDetailsBLL;
            this.IProductDetailsBLL = ProductDetailsBLL;
            this.IProductBLL = ProductBLL;
            this.ICustomerBLL = CustomerBLL;
        }
        [Route("don-hang")]
        public async Task<IActionResult> Index(DateTime FromDate, DateTime ToDate, int page = 1, string Search = null, string StateSaleOrder = null)
        {
            IEnumerable<SaleOrder> listSaleOrder = null;
            if (FromDate != DateTime.MinValue && ToDate != DateTime.MinValue)
            {
                if (FromDate.Date < ToDate.Date)
                {
                    ModelState.AddModelError("A1", "Định dạng ngày không chính xác");
                    return View(null);
                }
                listSaleOrder = await this.ISaleOrderBLL.Get(numberPerPage, page, p => (Search == null || (p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search || (StateSaleOrder == null || p.State.ToString() == StateSaleOrder)) && (p.ReviewDate.Date < FromDate.Date && p.ReviewDate.Date > ToDate.Date)));
                ViewBag.currentPage = page;
                ViewBag.totalPage = TotalPage(ISaleOrderBLL.Cout(p => (p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search || p.State.ToString() == StateSaleOrder) && (p.ReviewDate.Date < FromDate.Date && p.ReviewDate.Date > ToDate.Date)));

            }
            else
            {
                listSaleOrder = await this.ISaleOrderBLL.Get(currentPage: page, intNumber: numberPerPage, filter: p => Search == null || (p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search || (StateSaleOrder == null || p.State.ToString() == StateSaleOrder)));
                ViewBag.currentPage = page;
                ViewBag.totalPage = TotalPage(ISaleOrderBLL.Cout(p => Search == null || (p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search || (StateSaleOrder == null || p.State.ToString() == StateSaleOrder))));
            }
            var list = await ISaleOrderDetailsBLL.Get();
            return View(listSaleOrder);
        }
        [Route("xuat-hoa-don")]
        public async Task<IActionResult> ReportBill()
        {
            return View(await IProductBLL.Get());
        }
        public async Task<JsonResult> ConfirmSaleOrder(string strSaleOrderID)
        {
            SaleOrder objSaleOrder = await this.ISaleOrderBLL.Find(strSaleOrderID);
            if (objSaleOrder == null)
            {
                return Json(new { success = false, message = "Không tìm thấy đơn hàng" });
            }
            var ConfirmOrder = await this.ISaleOrderBLL.ConfirmSaleOrder(objSaleOrder, HttpContext.User.Identity.Name);
            if (ConfirmOrder)
                return Json(new { success = true, message = "Xac nhan don hang thang cong" });
            return Json(new { success = false, message = "Xac nhan don hang khong thanh cong vui long thu lai sau" });
        }
        [HttpGet]
        [Route("don-hang/chi-tiet")]
        public async Task<JsonResult> getDetails(string idsaleOrder)
        {
            var ListDetails = await ISaleOrderDetailsBLL.Get(filter: p => p.SaleOrderID == idsaleOrder);
            var lisCus = await ICustomerBLL.Get();
            var sale = await ISaleOrderBLL.Find(idsaleOrder);
            LoadSaleDetailsModel temp = new LoadSaleDetailsModel();
            List<string> ListTemp = new List<string>();
            List<int> tempQuan = new List<int>();
            List<LoadSaleDetailsModel> listTemp = new List<LoadSaleDetailsModel>();
            foreach (var i in ListDetails)
            {
                ListTemp.Add(i.ProductDetailId);
            }
            for (int i = 0; i < ListTemp.Count(); i++)
            {
                var t = await IProductDetailsBLL.Find(ListTemp[i]);
                var e = await IProductBLL.Find(t.ProductID);
                temp.ModelName = e.Model;
                temp.Color = t.TypeColor.ToString();
                temp.PricePro = e.Price;
                listTemp.Add(temp);

            }
            foreach (var i in ListDetails)
            {
                tempQuan.Add(i.Quality);
            }
            List<string> tempName = new List<string>();
            var j = 0;
            foreach (var i in lisCus)
            {
                if (i.Id == sale.CustomerID)
                {
                    listTemp[j].NameCus = i.CustomerName;
                    listTemp[j].PhoneCus = i.CustomerPhone;
                    listTemp[j].CMND = i.CMND;
                    listTemp[j].AdressDev = sale.ReceiveAddress;
                    j++;
                }
            }
            for (int i = 0; i < listTemp.Count(); i++)
            {
                listTemp[i].QuantityPro = tempQuan[i];
                listTemp[i].IDsaleOrder = idsaleOrder;
            }
            return Json(JsonConvert.SerializeObject(listTemp));
        }
    }
}