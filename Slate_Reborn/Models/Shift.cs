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
        [ForeignKey("BusinessInfo")]
        public int BusinessInfoId { get; set; }
        public virtual BusinessInfo BusinessInfo { get; set; }
    }
}