﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MonthlyBillsWithDapper.Entity
{
    public class MonthlyBill
    {
        public int id { get; set; }
        [Required]

        [StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        [Display(Name = "Bill")] 
        public string Bill { get; set; }
        [Required]
        [Range(0,100)]
        [Display(Name = "Cost")]
        public Nullable<float> Cost { get; set; }
        [Required]
        [Range(0, 31)] 
        public int Date { get; set; }
        public string BillAlias { get; set; }
        public string UserID { get; set; }
        public bool Paid_ { get; set; }
    }
}
