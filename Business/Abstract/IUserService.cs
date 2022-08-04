using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DataTransferObject;

namespace Business.Abstract
{
    public interface IUserService
    {
        void update(UserManagementDto userManagementDto);

        UserDataDto getUserById(int userId);
    }
}
