using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slate_Reborn.Models
{
    public class EmployeeRoles
    {
        [Key]
        public int EmpRoleId { get; set; }

        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }

        [ForeignKey("EmpId")]
        public int EmpId { get; set; }
        public virtual EmployeeInfo EmployeeInfo { get; set; }
    }
}