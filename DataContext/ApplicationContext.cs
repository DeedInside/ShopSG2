using ShopSG2.Model;

namespace ShopSG2.DataContext
{
    public static class ApplicationContext
    {
        public static Product product1 = new Product("Яблоко", "зеленое", 120, "default") { Id = 1 };
        public static Product product2 = new Product("Яблоко", "красное", 140, "default") { Id = 2 };
        public static Product product3 = new Product("банан", "спелый", 170, "default") { Id = 3 };

        public static List<ProductShop> productShops = new List<ProductShop>
        {
            new ProductShop(
                product1,
                product1.Price * 1.1,
                DateOnly.ParseExact("06 03 2024","dd mm yyyy"),
                DateOnly.ParseExact("10 03 2024","dd mm yyyy")
                ) { Id = 1},
             new ProductShop(
                product2,
                product2.Price * 1.1,
                DateOnly.ParseExact("06 03 2024","dd mm yyyy"),
                DateOnly.ParseExact("13 03 2024","dd mm yyyy")
                ) { Id = 2},
             new ProductShop(
                product3,
                product3.Price * 1.1,
                DateOnly.ParseExact("06 03 2024","dd mm yyyy"),
                DateOnly.ParseExact("15 03 2024","dd mm yyyy")
                ) { Id = 3}
        };
        public static List<Product> ListProducts = new List<Product>()
        {
            product1,
            product2,
            product3
        };
    }
}
