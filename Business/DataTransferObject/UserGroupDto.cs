using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DataTransferObject
{
    public class UserGroupDto
    {
        public string Name { get; set; }
        public List<DomainDto> Domains { get; set; }
    }
}
