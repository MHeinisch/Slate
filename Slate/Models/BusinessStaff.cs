using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slate.Models
{
    public class BusinessStaff
    {
        [Key]
        public string EmployeeId { get; set; }

        [Required]
        [Display(Name = "Job")]
        public string Job { get; set; }

        [Required]
        [Display(Name = "Employee Skill Level")]
        public string SkillLevel { get; set; }
    }
}