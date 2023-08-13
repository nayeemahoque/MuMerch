﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class ProductSizeMap
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
    }
}