using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBidClientService
    {
        DataResult<BidClient> GetById(int bidId);
        DataResult<List<BidClient>> GetAll();
        IResult Add(BidClient bid);
        IResult Update(BidClient bid);
        IResult Delete(BidClient bid);
    }
}
