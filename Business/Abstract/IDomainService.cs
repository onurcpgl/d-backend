using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DataTransferObject;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDomainService
    {
        Domain GetById(int vpnId);
        List<Domain> GetList();
        bool Add(LinkAddDataDto linkAddDataDto);
        void Delete(Domain vpn);
        void Update(Domain vpn);
    }
}
