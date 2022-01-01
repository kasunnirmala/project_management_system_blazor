using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Company
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [StringLength(25)]
        public String Name { get; set; }

        [StringLength(50)]
        public String Description { get; set; }

        public String Address { get; set; }
    }
}
