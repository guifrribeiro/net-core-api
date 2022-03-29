namespace Order.Domain.Models
{
    public class OrderItemModel
    {
        public OrderModel Order { get; set; }

        public ProductModel Product { get; set; }
        
        public decimal SellValue { get; set; }
        
        public int Quantity { get; set; }

        public decimal TotalAmount { get; set; }
    }
}