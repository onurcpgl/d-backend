using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDomainService
    {
        Domain GetById(int vpnId);
        List<Domain> GetList();
        void Add(Domain vpn);
        void Delete(Domain vpn);
        void Update(Domain vpn);
    }
}
