﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoRestaurant.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }

        public DateTime? DateCreated { get; set; }
        public virtual Product Product{ get; set; }
    }
}