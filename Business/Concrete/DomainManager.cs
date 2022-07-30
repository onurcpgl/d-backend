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
    public class DomainManager : IDomainService
    {
        private IDomainDal _vpnDal;

        public DomainManager(IDomainDal vpnDal)
        {
            _vpnDal = vpnDal;
        }
        public void Add(Domain vpn)
        {
            _vpnDal.Add(vpn);
        }

        public void Delete(Domain vpn)
        {
            _vpnDal.Delete(vpn);
        }

        public Domain GetById(int vpnId)
        {
            return _vpnDal.Get(v => v.Id == vpnId);
        }

        public List<Domain> GetList()
        {
            return _vpnDal.GetList(null,x=>x.UserGroups).ToList();
        }

        public void Update(Domain vpn)
        {
            _vpnDal.Update(vpn);
        }
    }
}
