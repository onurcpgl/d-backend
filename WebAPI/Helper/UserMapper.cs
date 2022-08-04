using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.DataTransferObject;
using Entities.Concrete;

namespace WebAPI.Helper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserGroupDto, UserGroup>().ReverseMap();
            CreateMap<DomainDto, Domain>().ReverseMap();
            CreateMap<UserDataDto, User>().ReverseMap();
        }
    }
}
