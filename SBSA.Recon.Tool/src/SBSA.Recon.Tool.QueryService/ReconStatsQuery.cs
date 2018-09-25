using AutoMapper;
using SBSA.Recon.Tool.Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.QueryService
{
    public class ReconStatsQuery : IQuery<Task<IEnumerable<AdaptivRecon>>>
    { }

    public class GetOneRowQuery<T>
        where T : IEntity, IQuery<Task<AdaptivRecon>>
    { }


    public class CommentQuery : IQuery<Task<IEnumerable<MetaAdaptivReconComment>>>
    { }

    public interface IEntity
    {
        int Id { get; set; }
    }
}
