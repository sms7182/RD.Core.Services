using System;
using System.Collections.Generic;
using System.Text;

namespace RD.Core.CommandQueryService
{
    public abstract class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public ErrorReport Error { get; set; }


    }
    public class ErrorReport
    {

    }
}
