using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITenderService
    {
        IResult Add(Tender tender);
        IResult Update(Tender tender);
        IResult Delete(Tender tender);
    }
}
