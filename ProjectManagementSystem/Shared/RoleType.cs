using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class RoleType
    {
        [Key]
        public Int32 Id { get; set; }

        public String Type { get; set; }
    }
}
