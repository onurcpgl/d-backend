using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.DataTransferObject;
using Entities.Concrete;

namespace WebAPI.Helper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UserGroupDto, UserGroup>().ReverseMap();
            CreateMap<DomainDto, Domain>().ReverseMap();
            CreateMap<UserDataDto, User>().ReverseMap();
            CreateMap<Announcement,AnnouncementDto>().ForMember(dest=>dest.UserName, opt => opt.MapFrom(src => src.User.Username));
            CreateMap<AnnouncementDataDto, Announcement>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.Now));

        }
    }
}
