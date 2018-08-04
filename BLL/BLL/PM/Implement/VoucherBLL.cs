﻿using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class VoucherBLL : GenericBLL, IGenericBLL<Voucher, string>
    {
        public VoucherBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Voucher> Find(string ID)
        {
            return this.unitOfWork.VoucherRepository.Find(ID);
        }
        public async Task<bool> Add(Voucher voucher, string CreatedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.VoucherRepository.Insert(voucher);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.VoucherRepository.Delete(entityID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<IEnumerable<Voucher>> Get(int intNumber = -1, int intSkippage = -1)
        {
            return this.unitOfWork.VoucherRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);
        }

        public async Task<bool> Update(Voucher voucher, string UpdatedUser = "adminstrator")
        {
            try
            {
                voucher.EditedUser = UpdatedUser;
                this.unitOfWork.VoucherRepository.Update(voucher);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }
    }
}
