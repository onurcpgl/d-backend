using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Office { get; set; }
       
        public int UserGroupId { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}
