using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Ticket
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [StringLength(25)]
        public String Title { get; set; }

        [StringLength(250)]
        public String Description { get; set; }

        public DateTime OriginalEstimateTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public String Status { get; set; }

        public Project Project { get; set; }

        public User User { get; set; }

    }
}
