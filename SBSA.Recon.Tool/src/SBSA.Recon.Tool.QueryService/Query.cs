using System;

namespace SBSA.Recon.Tool.QueryService
{
    [Serializable]
    public class Query : IQuery
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
