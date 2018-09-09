using AutoMapper;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBSA.Recon.Tool.Application.Mapper
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
                cfg.CreateMap<MetaAdaptivReconComment, CommentDto>();
            });
        }
    }
}
