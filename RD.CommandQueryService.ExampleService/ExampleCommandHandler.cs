using RD.Core.CommandQueryService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RD.CommandQueryService.ExampleService
{
    public class ExampleCommandHandler : BaseCommandHandler<CommandRequest, CommandResponse>
    {
        public ExampleCommandHandler(IUnitOfWork unitOfWork):base(unitOfWork)
        {

        }
        public async override Task<CommandResponse> Handle(CommandRequest request)
        {
            return new CommandResponse()
            {
                Error = null,
                IsSuccess = true
            };
        }
    }
}
