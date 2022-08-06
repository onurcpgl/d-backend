using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DataTransferObject;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAnnouncementsService
    {
        Announcement GetById(int announcementsId);
        List<AnnouncementDto> GetList();
        
        void Delete(Announcement announcements);
        void Update(Announcement announcements);
        bool Add(AnnouncementDataDto announcementData);
    }
}
