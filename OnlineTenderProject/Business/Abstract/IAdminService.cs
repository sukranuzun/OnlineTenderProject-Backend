using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdminService
    {
        DataResult<Admin> GetById(int adminId);
        DataResult<List<Admin>> GetAll();
        IResult Add(Admin admin);
        IResult Update(Admin admin);
        IResult Delete(Admin admin);
    }
}
