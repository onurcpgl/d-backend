using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAnnouncementsDal : IEntityRepository<Announcement>
    {
       
    }
}
