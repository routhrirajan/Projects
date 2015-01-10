using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFMVC.Domain.Commands;
using EFMVC.CommandProcessor.Command;
using EFMVC.Data.Repositories;
using EFMVC.Data.Infrastructure;

namespace EFMVC.Domain.Handlers
{
    public class DeletePostProfileHandler : ICommandHandler<DeletePostProfileCommand>
    {
        private readonly IPostProfileRepository postProfileRepository;
        private readonly IUnitOfWork unitOfWork;

        public DeletePostProfileHandler(IPostProfileRepository postProfileRepository, IUnitOfWork unitOfWork)
        {
            this.postProfileRepository = postProfileRepository;
            this.unitOfWork = unitOfWork;
        }

        public ICommandResult Execute(DeletePostProfileCommand command)
        {
            var postProfile = postProfileRepository.GetById(command.ProfileId);
            postProfileRepository.Delete(postProfile);
            unitOfWork.Commit();
            return new CommandResult(true);
        }
    }
}
