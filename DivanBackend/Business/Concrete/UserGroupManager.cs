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
    public class UserGroupManager : IUserGroupService
    {
        private IUserGroupDal _userDal;

        public UserGroupManager(IUserGroupDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(UserGroup entity)
        {
            _userDal.Add(entity);
        }

        public void Delete(UserGroup user)
        {
            _userDal.Delete(user);
        }

        public UserGroup GetById(int userId)
        {
            return _userDal.Get(u => u.Id == userId);
        }

        public List<UserGroup> GetList()
        {
            return _userDal.GetList(null,x=>x.Domains).ToList();
        }

        public void Update(UserGroup user)
        {
            _userDal.Update(user);
        }
    }
}
