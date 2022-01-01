using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Project
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [StringLength(25)]
        public String Name { get; set; }

        [StringLength(50)]
        public String Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Company Company { get; set; }
    }
}
