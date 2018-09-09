using SBSA.Recon.Tool.CommandService;

namespace SBSA.OffShore.Domain.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
