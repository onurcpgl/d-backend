using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DataTransferObject;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserGroupService
    {
        UserGroup GetById(int userId);
        List<UserGroup> GetList();
        void Add(UserGroup user);
        void Delete(UserGroup user);
        void Update(UserGroup user);

        List<UserDataDto> getUserGroupById(int userGroupId);
    }
}
