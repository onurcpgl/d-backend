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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IUserGroupDal _userGroupDal;
        private IMapper _mapper;

        public UserManager(IUserDal userDal, IUserGroupDal userGroupDal, IMapper mapper)
        {
            _userDal = userDal;
            _userGroupDal = userGroupDal;
            _mapper = mapper;
        }

        public UserDataDto getUserById(int userId)
        {
            User user = _userDal.GetList(x => x.Id == userId,y=>y.UserGroup,y=>y.UserGroup.Domains).FirstOrDefault();
            return  _mapper.Map<UserDataDto>(user);
        }

        public void update(UserManagementDto userManagementDto)
        {
            User user = _userDal.Get(x => x.Id == userManagementDto.userId);
            user.UserGroupId = userManagementDto.userGroupId;
            _userDal.Update(user); 
        }
    }
}
