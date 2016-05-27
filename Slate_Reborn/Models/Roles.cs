using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slate_Reborn.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        public string Title { get; set; }

    }
}