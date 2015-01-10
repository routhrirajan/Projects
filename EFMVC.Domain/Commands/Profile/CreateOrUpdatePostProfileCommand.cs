using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFMVC.CommandProcessor.Command;

namespace EFMVC.Domain.Commands
{
    public class CreateOrUpdatePostProfileCommand : ICommand
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }
        public string Headline { get; set; }
        public int DesignationId { get; set; }
        public int LocationId { get; set; }
        public int TotalExperience { get; set; }
        public int Mobile { get; set; }
        public int Landline { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string FileName { get; set; }
        public string FileURL { get; set; }
    }
}
