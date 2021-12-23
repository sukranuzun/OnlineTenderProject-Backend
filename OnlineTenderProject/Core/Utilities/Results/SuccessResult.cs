using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        private string deleted;

        public SuccessResult(string deleted)
        {
            this.deleted = deleted;
        }
    }
}
