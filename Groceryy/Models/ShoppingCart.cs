namespace Grocery.Models
{
    public class ShoppingCart
    {
        public List <ShoppingCartItems>Items {  get; set; } = new List<ShoppingCartItems> (); 

        public void AddItem(productItems product)
        {
            ShoppingCartItems existing = Items.FirstOrDefault(i => i.prodCode == product.prodCode);

            if (existing != null)
            {
                existing.prodQuant++;
            }
            else
            {
                Items.Add(new ShoppingCartItems
                {
                    prodCode = product.prodCode,
                    prodDescription = product.prodDescription,
                    prodPrice = product.prodPrice,
                    prodQuant = 1
                });
            }
        }
        public decimal CalculateTotal()
        {
            return Items.Sum(i => i.prodPrice * i.prodQuant);
        }
    }
}
