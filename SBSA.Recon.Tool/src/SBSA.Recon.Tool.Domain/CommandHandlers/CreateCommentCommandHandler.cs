using System;
using AutoMapper;
using SBSA.OffShore.CommandService.Commands;
using SBSA.OffShore.Domain.CommandHandlers;
using SBSA.OffShore.Domain.Configuration;
using SBSA.OffShore.Domain.Item;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.Infrastructure.Service.Persistence;

namespace SBSA.OffShore.Domain.CommandHandlers
{
    public class CreateCommentCommandHandler : 
                    ICommandHandler<CreateCommentCommand>
    {
        private ICommandServiceRepository<MetaAdaptivReconComment> _repository;
        public IMapper Mapper
        {
            get
            {
                return new Map().Config.CreateMapper();
            }
        }
        public CreateCommentCommandHandler(ICommandServiceRepository<MetaAdaptivReconComment> repository)
        {
            _repository = repository;
        }

        public async  void Execute(CreateCommentCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
            var instruction = await _repository.FindAsync(command.Id);

            var aggregate = new CommentItem
                    (command.Id, command.AdaptivReconId, command.Reference, command.ReconStatus,
                        command.Comments, command.Username, command.BusinessDate, command.CommentDate);

            if (instruction != null)
                await _repository.UpdateAsync(Mapper.Map<CommentItem, MetaAdaptivReconComment>(aggregate));
            else
                await _repository.AddAsync(Mapper.Map<CommentItem, MetaAdaptivReconComment>(aggregate));
            
               
        }
    }
}
