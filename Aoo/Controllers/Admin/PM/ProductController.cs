﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    [Authorize]
    public class ProductController : BaseController
    {
        private readonly IProductBLL ProductBLL;
        private readonly IBrandBLL BrandBLL;
        private readonly ICategoryBLL CategorytBLL;
        private readonly IMainGroupBLL MainGroupBLL;
        private readonly ISubGroupBLL SubGroupBLL;
        private readonly IProductDetailsBLL ProductDetailsBLL;
        public ProductController(IProductBLL productBLL, IProductDetailsBLL productDetailsBLL, ISubGroupBLL subGrouptBLL, IMainGroupBLL mainGroupBL, IBrandBLL brandBLL, ICategoryBLL categoryBLL, IImageServices imageServices) : base(imageServices)
        {
            ProductBLL = productBLL;
            this.MainGroupBLL = mainGroupBL;
            this.BrandBLL = brandBLL;
            this.CategorytBLL = categoryBLL;
            this.SubGroupBLL = subGrouptBLL;
            this.ProductDetailsBLL = productDetailsBLL;
        }

        public async Task<IActionResult> Index(int page = 1, string contain = null)
        {
            ViewBag.currentPage = page;
            ViewBag.totalPage = TotalPage(ProductBLL.Cout());
            if (contain != null)
            {
                var ListResult = await ProductBLL.Get(numberPerPage, page, filter: p => p.Model.Contains(contain));
                ViewBag.currentPage = page;
                ViewBag.totalPage = TotalPage(ProductBLL.Cout(filter: p => p.Model.Contains(contain)));
                return View(ListResult);
            }
            var listProduct = await ProductBLL.Get(numberPerPage, page, orderBy: p => p.OrderByDescending(x => x.EditedDate));
            return View(listProduct);


        }

        public async Task<IActionResult> AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ViewModels.PM.AddProductViewModel addProductViewModel)
        {

            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(addProductViewModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Product product = new Product()
                    {
                        //MetaKey=addProductViewModel.MetaKey,
                        MetaTitle=addProductViewModel.MetaTitle,
                        MetaDescription=addProductViewModel.MetaDescription,
                        Model = addProductViewModel.Model,
                        //MetaKey=adProductViewModel.MetaTitle,
                        DefaultImage = ImagePath,
                        Price = addProductViewModel.DefauftPrice,
                        isOnlineOnly = addProductViewModel.isOnlineOnly,
                        IsAllowComment = addProductViewModel.IsAllowComment,
                        StockMin = addProductViewModel.StockMin,
                        //LadingPage = addProductViewModel.LadingPage,
                    };
                    product.BrandID = addProductViewModel.Brand;
                    product.CategoryID = addProductViewModel.Category;
                    //product.MainGroup = await MainGroupBLL.Find(addProductViewModel.MainGroup);
                    product.SubGroupID = addProductViewModel.SubGroup;
                    await ProductBLL.Add(product);
                    return RedirectToAction("Index");

                }

            }
            return View();
        }
        public async Task<IActionResult> EditProduct(string id)
        {
            Product objproduct = await this.ProductBLL.Find(id);

            ViewModels.PM.Product.EditProductViewModel editProductViewModel = new ViewModels.PM.Product.EditProductViewModel
            {

                OldImage = objproduct.DefaultImage,
                DefauftPrice = objproduct.Price,
                //DefaultImage=objproduct.DefaultImage,
                SubGroup = objproduct.SubGroupID,
                Category = objproduct.CategoryID,
                Brand = objproduct.BrandID,
                IsAllowComment = objproduct.IsAllowComment,
                CreateTime = objproduct.CreatedTime

            };
            return View(editProductViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditProduct(ViewModels.PM.Product.EditProductViewModel editProductViewModel)
        {
            string ImagePath = null; ;
            ImageErrorModel imageErrorModel = new ImageErrorModel();
            if (editProductViewModel.DefaultImage == null)
            {
                ImagePath = editProductViewModel.OldImage;
            }
            else
            {
                ImagePath = UploadImage(editProductViewModel.DefaultImage, ref imageErrorModel);
            }
            if (ModelState.IsValid)
            {
                     
                Product objProduct = await this.ProductBLL.Find(editProductViewModel.ID);
                objProduct.ID = editProductViewModel.ID;
                objProduct.Specification = editProductViewModel.Specification;
                objProduct.DefaultImage = ImagePath;
                objProduct.Price = editProductViewModel.DefauftPrice;
                objProduct.isOnlineOnly = editProductViewModel.isOnlineOnly;
                objProduct.StockMin = editProductViewModel.StockMin;
                objProduct.Details = editProductViewModel.Details;
                objProduct.IsAllowComment = editProductViewModel.IsAllowComment;
                objProduct.CreatedTime = editProductViewModel.CreateTime;
                objProduct.BrandID = editProductViewModel.Brand;
                objProduct.CategoryID = editProductViewModel.Category;
                objProduct.SubGroupID = editProductViewModel.SubGroup;
                await ProductBLL.Update(objProduct);
                return RedirectToAction("Index");
            }
            return View(editProductViewModel);
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await ProductBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }
    }
}