using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.Application.Commands
{
    public class CreateUserCommand:IRequest<string>
    {
        public string Name { get; set; }
    }
}
