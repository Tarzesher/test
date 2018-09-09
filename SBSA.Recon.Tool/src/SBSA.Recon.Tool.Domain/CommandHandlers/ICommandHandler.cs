using SBSA.OffShore.CommandService;
using SBSA.Recon.Tool.CommandService;
using System;

namespace SBSA.OffShore.Domain.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
