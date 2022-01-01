using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class User
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [StringLength(25)]
        public String Name { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        public RoleType Role { get; set; }

        public Guid RoleId { get; set; }
    }
}
