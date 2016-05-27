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

        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string WeekDay { get; set; }
    }
}