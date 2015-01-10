using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFMVC.Domain.Commands;
using EFMVC.CommandProcessor.Command;
using EFMVC.Data.Repositories;
using EFMVC.Data.Infrastructure;
using EFMVC.Model;

namespace EFMVC.Domain.Handlers
{
    public class CreateOrUpdatePostProfileHandler : ICommandHandler<CreateOrUpdatePostProfileCommand>
    {
        private readonly IPostProfileRepository postProfileRepository;
        private readonly IUnitOfWork unitOfWork;

        public CreateOrUpdatePostProfileHandler(IPostProfileRepository postProfileRepository, IUnitOfWork unitOfWork)
        {
            this.postProfileRepository = postProfileRepository;
            this.unitOfWork = unitOfWork;
        }

        public ICommandResult Execute(CreateOrUpdatePostProfileCommand command)
        {
            var postProfile = new PostProfile
            {
                ProfileId = command.ProfileId,
                DesignationId = command.DesignationId,
                DOB = command.DOB,
                Email = command.Email,
                FileName = command.FileName,
                FileURL = command.FileURL,
                Gender = command.Gender,
                Headline = command.Headline,
                Landline = command.Landline,
                LocationId = command.LocationId,
                Mobile = command.Mobile,
                TotalExperience = command.TotalExperience,
                UserId = command.UserId                
            };
            if (command.ProfileId == 0)
                postProfileRepository.Add(postProfile);
            else
                postProfileRepository.Update(postProfile);
            unitOfWork.Commit();
            return new CommandResult(true);
        }
    }
}
