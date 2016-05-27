using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slate_Reborn.Models
{
    public class EmployeeShifts
    {
        [Key]
        public int EmpShiftId { get; set; }

        [ForeignKey("ShiftId")]
        public int ShiftId { get; set; }
        public virtual Shift Shift { get; set; }

        [ForeignKey("EmpId")]
        public int EmpId { get; set; }
        public virtual EmployeeInfo EmployeeInfo { get; set; }
    }
}