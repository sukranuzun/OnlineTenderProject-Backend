using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBidClientService
    {
        DataResult<BidClient> GetById(int bidClientId);
        DataResult<List<BidClient>> GetAll();
        IResult Add(BidClient bidClient);
        IResult Update(BidClient bidClient);
        IResult Delete(BidClient bidClient);
    }
}
