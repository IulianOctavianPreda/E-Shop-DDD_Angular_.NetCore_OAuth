﻿using System;
using Domain.Core.OrderManagement;
using Domain.Core.ProductManagement;

namespace Domain.Core.OrderItemsManagement
{
    public class OrderItems
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
