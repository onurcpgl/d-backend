using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.DataTransferObject
{
    public class UserDataDto
    {
        public string Username;
        public UserGroupDto UserGroup;
    }
}
