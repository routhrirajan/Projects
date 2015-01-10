using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFMVC.CommandProcessor.Command;

namespace EFMVC.Domain.Commands
{
    public class DeletePostProfileCommand : ICommand
    {
        public int ProfileId { get; set; }
    }
}
