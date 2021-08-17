using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace RD.Core.CommandQueryService
{
    public abstract class BaseCommandRequest<U> : IRequest<U> where U : BaseResponse
    {
        public Guid Id { get; set; }
    }
}
