using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClientService
    {
        IResult Add(Client client);
        IResult Update(Client client);
        IResult Delete(Client client);
        IDataResult<Client> GetById(int clientId);
        IDataResult<List<Client>> GetAll();
    }
}
