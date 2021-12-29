using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private bool success;
        private string message;

        public Result(bool success)
        {
            this.success = success;
        }

        public Result(bool success, string message)
        {
            this.success = success;
            this.message = message;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
