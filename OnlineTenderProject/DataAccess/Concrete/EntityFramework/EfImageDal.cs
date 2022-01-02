using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfImageDal : EfEntityRepositoryBase<Image, DataContext>, IImageDal
    {
        public List<Image> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
