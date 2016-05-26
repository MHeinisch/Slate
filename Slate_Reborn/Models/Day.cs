﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slate_Reborn.Models
{
    public class Day
    {
        [Key]
        public int DayId { get; set; }
        public System.DateTime Date { get; set; }
    }
}