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
        Announcements GetById(int announcementsId);
        List<Announcements> GetList();
        void Add(Announcements announcements);
        void Delete(Announcements announcements);
        void Update(Announcements announcements);
    }
}
