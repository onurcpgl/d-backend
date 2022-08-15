using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.DataTransferObject;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AnnouncementsManager : IAnnouncementsService
    {
        private IAnnouncementsDal _announcementsDal;
        private IMapper _mapper;
        private IUserDal _userDal;


        public AnnouncementsManager(IAnnouncementsDal announcementsDal, IMapper mapper, IUserDal userDal)
        {
            _announcementsDal = announcementsDal;
            _mapper = mapper;
            _userDal = userDal;
        }
        

        public bool Add(AnnouncementDataDto announcementData)
        {
            var result=_mapper.Map<Announcement>(announcementData);
            var user = _userDal.Get(x => x.Id == result.UserId);
            if (user.UserGroupId == 2)
            {
                _announcementsDal.Add(result);
                return true;
            }
            else
            {
                return false;  
            }
        }

        public void Delete(Announcement announcements)
        {
            _announcementsDal.Delete(announcements);
        }

        public Announcement GetById(int announcementsId)
        {
            return _announcementsDal.Get(a => a.Id == announcementsId);
        }

        public List<AnnouncementDto> GetList()
        {
            var result = _announcementsDal.GetList(null, x => x.User).ToList();
            return _mapper.Map<List<AnnouncementDto>>(result);
        }
        

        public void Update(Announcement announcements)
        {
            _announcementsDal.Update(announcements);
        }
    }
}
