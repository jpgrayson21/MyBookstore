using Microsoft.AspNetCore.Mvc;
using MyBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//To help enable the cart icon/basket view on the index page
namespace MyBookstore.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private Basket basket;

        public BasketSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
