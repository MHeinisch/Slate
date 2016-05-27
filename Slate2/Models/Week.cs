using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slate_Reborn.Models
{
    public class Week
    {
        [Key]
        public int WeekId { get; set; }
        public string StartDate { get; set; }
    }
}