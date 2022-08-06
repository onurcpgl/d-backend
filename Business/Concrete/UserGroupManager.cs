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
    public class UserGroupManager : IUserGroupService
    {
        private IUserGroupDal _userGroupDal;
        private IUserDal _userDal;
        private IMapper _mapper;

        public UserGroupManager(IUserGroupDal userGroupDal,IMapper mapper,IUserDal userDal)
        {
            _userGroupDal = userGroupDal;
            _userDal = userDal;
            _mapper = mapper;
        }
        public void Add(UserGroup entity)
        {
            _userGroupDal.Add(entity);
        }

        public void Delete(UserGroup user)
        {
            _userGroupDal.Delete(user);
        }

        public UserGroup GetById(int userId)
        {
            return _userGroupDal.Get(u => u.Id == userId);
        }

        public List<UserGroup> GetList()
        {
            return _userGroupDal.GetList(null,x=>x.Domains).ToList();
        }

        public List<UserDataDto> getUserGroupById(int userGroupId)
        {
            List<User> itUserGroup = _userDal.GetList(x => x.UserGroup.Id == userGroupId, x => x.UserGroup, x => x.UserGroup.Domains).ToList();
            return _mapper.Map<List<UserDataDto>>(itUserGroup);
        }
        
        public void Update(UserGroup user)
        {
            _userGroupDal.Update(user);
        }
    }
}
