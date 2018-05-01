﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O2O_Server.Common
{
    public class ApiException : ApplicationException
    {
        public CodeMessage code;
        public string msg;

        public ApiException(CodeMessage code, string msg)
        {
            this.code = code;
            this.msg = msg;
        }
    }
}
