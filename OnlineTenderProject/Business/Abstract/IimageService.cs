using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IimageService
    {
        IResult Add(Image image);
        IResult Update(Image image);
        IResult Delete(Image image);
        IDataResult<Image> GetById(int imageId);
        IDataResult<List<Image>> GetAll();
    }
}
