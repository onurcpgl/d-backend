using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class UserGroup : IEntity
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Domain> Domains{ get; set; }
        public ICollection<User> User { get; set; }

       
    }
}
