﻿using System;

namespace Solid05.DIP.Models
{
    public class OrderItemModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string UnitOfMeasure { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
