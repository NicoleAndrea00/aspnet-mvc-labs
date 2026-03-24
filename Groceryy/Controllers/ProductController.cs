using Grocery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grocery.Controllers
{
    public class ProductController : Controller
    {
        private static List<productItems> _products = new List<productItems>
        {
            new productItems {prodCode="P001", prodDescription="Cheese", prodPrice=2.99m},
            new productItems {prodCode="P002", prodDescription="Shampoo", prodPrice=3.50m},
            new productItems {prodCode="P003", prodDescription="Lotion", prodPrice=2.50m},
            new productItems {prodCode="P004", prodDescription="Maltesers", prodPrice=3.99m}
        };

        private static ShoppingCart _cart = new ShoppingCart();

        // GET: ProductController
        public ActionResult Index()
        {
            ViewBag.CartTotal = _cart.CalculateTotal();
            return View(_products);
        }

        // GET: ProductController/Details/5
        public ActionResult AddToCart(string prodCode)
        {
            productItems product = _products.FirstOrDefault(p=>p.prodCode == prodCode);
            if (product != null)
            {
                _cart.AddItem(product);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Cart()
        {
            ViewBag.CartTotal = _cart.CalculateTotal();
            return View(_cart.Items);
        }

        //To do: Incomplete
        public ActionResult Payment()
        {
            ViewBag.CartTotal = _cart.CalculateTotal();
            return View(_cart.Items);
        }

    }
}
