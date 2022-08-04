using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAnnouncementsService
    {
        Announcement GetById(int announcementsId);
        List<Announcement> GetList();
        void Add(Announcement announcements);
        void Delete(Announcement announcements);
        void Update(Announcement announcements);
    }
}
