using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, DataContext>, IAdminDal
    {
    }
}
