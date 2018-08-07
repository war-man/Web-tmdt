﻿using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class TransportTypeBLL : GenericBLL, IGenericBLL<TransportType, string>
    {
        public TransportTypeBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Add(TransportType transportType, string CreatedUser = "adminstrator")
        {
            try
            {
                transportType.CreatedUser = CreatedUser;
                this.unitOfWork.TransportTypeRepository.Insert(transportType);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public int Cout()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.TransportPriceRepository.Delete(entityID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<TransportType> Find(string ID)
        {
            return this.unitOfWork.TransportTypeRepository.Find(ID);

        }

      

        public async Task<IEnumerable<TransportType>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<TransportType, bool>> filter = null, Func<IQueryable<TransportType>, IOrderedQueryable<TransportType>> orderBy = null)
        {
            try
            {
                return unitOfWork.TransportTypeRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return null;
            }
        }

        public async Task<bool> Update(TransportType transportType, string UpdatedUser = "adminstrator")
        {
            try
            {
                transportType.EditedUser = UpdatedUser;
                this.unitOfWork.TransportTypeRepository.Update(transportType);
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
