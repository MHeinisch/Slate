using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slate_Reborn.Models
{
    public class AvailableShifts
    {
        [Key]
        public int EmpShiftId { get; set; }

        [ForeignKey("Shift")]
        public int ShiftId { get; set; }
        public virtual Shift Shift { get; set; }

        [ForeignKey("Availability")]
        public int AvailableId { get; set; }
        public virtual Availability Availability { get; set; }
    }
}