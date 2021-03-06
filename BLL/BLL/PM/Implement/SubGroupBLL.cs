﻿using CacheHelpers;
using DAL;
using DAL.Model;
using DAL.Model.PM;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM
{
    public class SubGroupBLL : GenericBLL, ISubGroupBLL
    {
        public SubGroupBLL(IUnitOfWork unitOfWork, IDataCache DataCache) : base(unitOfWork, DataCache)
        {
        }

        public async Task<bool> Add(SubGroup SubGroup, string CreatedUser = "adminstrator")
        {
            try
            {
                SubGroup.UrlFriendly = SubGroup.Name.UrlFriendLy();
                SubGroup.CreatedUser = CreatedUser;
                this.unitOfWork.SubGroupRepository.Insert(SubGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string SubGroupID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.SubGroupRepository.Delete(SubGroupID,DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public async Task<SubGroup> Find(string ID)
        {
           return this.unitOfWork.SubGroupRepository.Find(ID);
        }

       

        public async Task<IEnumerable<SubGroup>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<SubGroup, bool>> filter = null, Func<IQueryable<SubGroup>, IOrderedQueryable<SubGroup>> orderBy = null, string includeProperties = null)
        {
            try
            {
                return unitOfWork.SubGroupRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage,includeProperties:includeProperties);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public async Task<bool> Update(SubGroup subGroup, string UpdatedUser = "adminstrator")
        {
            try
            {
                subGroup.EditedUser = UpdatedUser;
                subGroup.UrlFriendly = subGroup.Name.UrlFriendLy();
                this.unitOfWork.SubGroupRepository.Update(subGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }
        public int Cout(Expression<Func<SubGroup, bool>> filter = null)
        {
            return this.unitOfWork.SubGroupRepository.Cout(filter);
        }

        public SubGroup SearchByUrl(string url)
        {
            return this.unitOfWork.SubGroupRepository.SearchByUrl(url);
        }
    }
}
