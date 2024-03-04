using AutoMapper;
using Pagi.Core.DTOs;
using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Turn, TurnDto>().ReverseMap();
            CreateMap<Clerk,ClerckDto>().ReverseMap();
        }
    }
}
