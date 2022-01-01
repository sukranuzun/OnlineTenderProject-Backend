using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Abstract
{
    public interface ITenderDal : IEntityRepository<Tender>
    {
        List<TenderDetailDto> GetByFilter(int categoryId);
        List<TenderDetailDto> GetTenderDetails();
        List<Tender> GetAll(Func<object, bool> p);
    }
}
