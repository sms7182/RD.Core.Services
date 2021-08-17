using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RD.Core.CommandQueryService
{
    public abstract class BaseCommandHandler<T,U> : IRequestHandler<T,U> where T:BaseCommandRequest<U>,new() where U:BaseResponse
    {
        public IUnitOfWork UnitOfWork { get;  }
        public BaseCommandHandler(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public abstract Task<U> Handle(T request);
        public Task<U> Handle(T request, CancellationToken cancellationToken)
        {
           return Handle(request);

           

        }

      
    }
  
    
   
    public interface IUnitOfWork
    {

    }

    public class UnitOfWork : IUnitOfWork
    {

    }


}
