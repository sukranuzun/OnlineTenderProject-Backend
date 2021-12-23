using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : IDataResult<T>
    {
        public T Data => throw new NotImplementedException();

        public bool Success => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();

    }
}
