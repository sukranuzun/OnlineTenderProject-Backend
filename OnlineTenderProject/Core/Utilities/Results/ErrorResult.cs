using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    class ErrorResult : IResult
    {
        public bool Success => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();
    }
}
