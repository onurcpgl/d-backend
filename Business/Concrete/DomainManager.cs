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
    public class DomainManager : IDomainService
    {
        private IDomainDal _vpnDal;
        private IMapper _mapper;
        private IUserDal _userDal;
        private IDomainDal _domainDal;


        public DomainManager(IDomainDal vpnDal, IMapper mapper, IUserDal userDal, IDomainDal domainDal)
        {
            _vpnDal = vpnDal;
            _userDal = userDal;
            _mapper = mapper;
            _domainDal = domainDal;
        }
        public void Add(Domain vpn)
        {
            _vpnDal.Add(vpn);
        }

        public bool Add(LinkAddDataDto linkAddDataDto)
        {
            var result = _mapper.Map<Domain>(linkAddDataDto);
            var user = _userDal.Get(x => x.Id == 1);
            if (user.UserGroupId == 1)
            {
                _domainDal.Add(result);
                return true;
            }
            else
            {
                return false;
            }
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
            return _vpnDal.GetList().ToList();
        }

        public void Update(Domain vpn)
        {
            _vpnDal.Update(vpn);
        }
    }
}
