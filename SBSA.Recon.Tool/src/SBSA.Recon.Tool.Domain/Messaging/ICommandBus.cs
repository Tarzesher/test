using SBSA.Recon.Tool.CommandService;
using SBSA.Recon.Tool.QueryService;

namespace SBSA.Recon.Tool.Domain.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
