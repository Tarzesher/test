using SBSA.OffShore.CommandService;
using SBSA.Recon.Tool.CommandService;

namespace SBSA.OffShore.Domain.CommandHandlers
{
    public interface IQueryandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}