﻿
using AlonsoAdmin.Common.Auth;
using AlonsoAdmin.Entities.System;
using AlonsoAdmin.Repository.System.Interface;

namespace AlonsoAdmin.Repository.System.Implement
{
    public class SysResourceRepository : RepositoryBase<SysResourceEntity>, ISysResourceRepository
    {
        public SysResourceRepository(IMultiTenantDbFactory dbFactory, IAuthUser user) : base(dbFactory.Db(Constants.SystemDbKey), user)
        {
        
        }
    }
}
