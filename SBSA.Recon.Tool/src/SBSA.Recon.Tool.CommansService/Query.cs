using SBSA.Recon.Tool.CommansService;
using System;

namespace SBSA.Recon.Tool.CommandService
{
    [Serializable]
    public class Query : ICommand
    {
        public int Id { get; private set; }
        public int Version { get; private set; }
        public Query(int id, int version)
        {
            Id = id;
            Version = version;
        }
    }
}
