using SBSA.Recon.Tool.CommandService;

namespace SBSA.Recon.Tool.Domain.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
