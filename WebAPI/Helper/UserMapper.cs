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
        //public UserMapper()
        //{
        //    CreateMap<UserSave, UserGroup>().ForMember(dest => dest.Name, src => src.MapFrom(s => s.name));
        //    CreateMap<UserSave, UserGroup>().ForMember(dest => dest.Surname, src => src.MapFrom(s => s.surname));
        //}
    }
}
