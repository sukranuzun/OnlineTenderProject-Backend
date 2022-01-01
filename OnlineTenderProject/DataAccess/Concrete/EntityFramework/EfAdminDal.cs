using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, DataContext>, IAdminDal
    {
        public List<Admin> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
