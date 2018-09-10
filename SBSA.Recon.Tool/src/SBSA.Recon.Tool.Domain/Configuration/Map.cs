using AutoMapper;
using SBSA.OffShore.Domain.Item;
using SBSA.Recon.Tool.Infrastructure.Entities;

namespace SBSA.OffShore.Domain.Configuration
{
    public class Map : Profile
    {
        public MapperConfiguration Config { get; set; }

        public Map(MapperConfiguration config)
        {
            this.Config = config;
        }

        public Map()
        {
            Config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CommentItem, MetaAdaptivReconComment>();
                
            });
        }
    }
}
