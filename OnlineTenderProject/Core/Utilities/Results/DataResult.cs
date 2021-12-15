using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool v)
        {
        }

        public T Data => throw new NotImplementedException();

        public bool Success => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();
    }
}
