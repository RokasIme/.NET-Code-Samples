using ShopApplication.Models;

namespace ShopApplication
{
    internal class Shop
    {
        private Customer _customer = new Customer();

        private List<ShopItem> _shopItems = new List<ShopItem>()
        {
            new ShopItem(){ Name = "IceCream", Price = 1, Quantity = 4 },
            new ShopItem(){ Name = "Candy", Price = 2, Quantity = 4},
            new ShopItem(){ Name = "ApplePie", Price = 3, Quantity = 4},
            };

        public void Buy(string name, int amount)
        {
            var item = _shopItems.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                throw new ArgumentException($"Item with name {name} not found.");
            }

            if ((item.Quantity - amount ) < 0 )
            {
                throw new ArgumentException($"Isufficient quantity of {name}, Shop have only {item.Quantity} of {item.Name}.");
            }

            var totalPrice = item.Price * amount;

            var balance = _customer.GetBalance();

            if (totalPrice <= balance)
            { 
                _customer.Charge(totalPrice);
                item.Quantity -= amount;
            }
            else
            {
                throw new ArgumentException($"Not enough balance. Your balance is {balance} Eur, but total price is {totalPrice} Eur.");
            }
        }

        public int GetCustomerBalance()
        {
            return _customer.GetBalance();
        }

        public string GetShopItemsInfo()
        {
            var shopItemsWithQuantity = _shopItems.Where(item => item.Quantity > 0);
            var info = "";
            foreach (var shopItem in shopItemsWithQuantity)
            {
                var shopItemInfo = $"name: {shopItem.Name}, quantity: {shopItem.Quantity}, price: {shopItem.Price} Eur. \n";
                info = info + shopItemInfo;
            }

            return info;
        }
    }
}
