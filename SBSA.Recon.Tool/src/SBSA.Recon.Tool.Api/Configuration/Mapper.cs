using AutoMapper;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.Api.Configuration
{
    public class MapperConfig
    {
        public MapperConfiguration Config { get; set; }

        public MapperConfig(MapperConfiguration config)
        {
            this.Config = config;
        }

        public MapperConfig()
        {
            Config = new MapperConfiguration(cfg => {
                cfg.CreateMap<MetaAdaptivReconComment, CommentDto>();
                cfg.CreateMap<AdaptivRecon, AdaptivReconDto>();

            });
        }
    }
}
