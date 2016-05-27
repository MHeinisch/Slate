using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slate_Reborn.Models
{
    public class Availability
    {
        [Key]
        public int AvailableId { get; set; }

        [ForeignKey("EmployeeInfo")]
        public int EmpId { get; set; }
        public virtual EmployeeInfo EmployeeInfo { get; set; }
        public string Weekday { get; set; }

    }
}