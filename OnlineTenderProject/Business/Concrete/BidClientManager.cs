using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BidClientManager : IBidClientService
    {
        IBidClientDal _bidClientDal;
        public BidClientManager(IBidClientDal bidClientDal)
        {
            _bidClientDal = bidClientDal;
        }


        public IResult Add(BidClient bidClient)
        {
            _bidClientDal.Add(bidClient);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(BidClient bidClient)
        {
            _bidClientDal.Delete(bidClient);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<BidClient> GetById(int bidId)
        {
            return new SuccessDataResult<BidClient>(_bidClientDal.Get(b => b.BidClientId == bidId));
        }

        public IResult Update(BidClient bidClient)
        {
            _bidClientDal.Update(bidClient);
            return new SuccessResult(Messages.Updated);
        }

        DataResult<List<BidClient>> IBidClientService.GetAll()
        {
            throw new NotImplementedException();
        }

        DataResult<BidClient> IBidClientService.GetById(int bidClientId)
        {
            throw new NotImplementedException();
        }
    }
}
