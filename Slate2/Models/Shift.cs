using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Slate_Reborn.Models
{
    public class Shift
    {
        [Key]

        public int ShiftId { get; set; }
        public string TimeOfDay { get; set; }
        public int WeekDay { get; set; }

        [ForeignKey("EmployeeInfo")]
        public int EmpId { get; set; }
        public virtual EmployeeInfo EmployeeInfo { get; set; }
    }
}