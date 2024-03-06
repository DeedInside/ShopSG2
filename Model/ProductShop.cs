namespace ShopSG2.Model
{
    public class ProductShop
    {
        public ProductShop(Product product, double price, DateOnly receiptDate, DateOnly expirationDate)
        {
            Product = product;
            Price = price;
            ReceiptDate = receiptDate;
            ExpirationDate = expirationDate;
        }
        public ProductShop() { }
        public int Id { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// Цена с учетом наценки магазина
        /// </summary>
        public double Price {  get; set; }
        /// <summary>
        /// Дата поступления товара
        /// </summary>
        public DateOnly ReceiptDate { get; set; }
        /// <summary>
        /// Дата окончания срока годности
        /// </summary>
        public DateOnly ExpirationDate { get; set; }

    }
}
