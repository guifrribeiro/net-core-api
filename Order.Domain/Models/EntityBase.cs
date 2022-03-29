using System;
using System.Collections.Generic;

namespace Order.Domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; }
    
        public DateTime CreatedAt { get; set; }

        public List<OrderItemModel> Items { get; set; }
    }
}