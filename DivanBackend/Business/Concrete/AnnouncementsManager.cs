using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AnnouncementsManager : IAnnouncementsService
    {
        private IAnnouncementsDal _announcementsDal;

        public AnnouncementsManager(IAnnouncementsDal announcementsDal)
        {
            _announcementsDal = announcementsDal;
        }
        public void Add(Announcements announcements)
        {
            _announcementsDal.Add(announcements);
        }

        public void Delete(Announcements announcements)
        {
            _announcementsDal.Delete(announcements);
        }

        public Announcements GetById(int announcementsId)
        {
            return _announcementsDal.Get(a => a.Id == announcementsId);
        }

        public List<Announcements> GetList()
        {
            return _announcementsDal.GetList().ToList();
        }

        public void Update(Announcements announcements)
        {
            _announcementsDal.Update(announcements);
        }
    }
}
