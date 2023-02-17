using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzasDb = new List<PizzasModel>
        {

            new PizzasModel() { ImageTitle="Margerita", PizzaName="Margerita", basePrice = 2,TomatoSauce=true,Cheese = true, FinalPrice = 4},
            new PizzasModel() { ImageTitle="Bolognese", PizzaName="Bolognese",basePrice =2,TomatoSauce=true,Cheese=true,Beef = true , FinalPrice = 5},
            new PizzasModel() { ImageTitle="Seafood",PizzaName="Seafood", basePrice=2,TomatoSauce=true,Cheese = true, Tuna = true, FinalPrice = 5},
            new PizzasModel() { ImageTitle="Mushroom",PizzaName="Mushroom", basePrice=2,TomatoSauce=true,Cheese= true,Ham = true,Mushrooms= true,FinalPrice = 6},
            new PizzasModel() { ImageTitle="MeatFeast",PizzaName="MeatFeast",basePrice=2,TomatoSauce=true,Cheese=true,Ham = true,Mushrooms= true,Beef= true , FinalPrice = 7},
            new PizzasModel() { ImageTitle="Vegetarian",PizzaName="Vegetarian",basePrice=2,TomatoSauce=true,Mushrooms= true,Pineapple=true,FinalPrice = 5}
        };
        public void OnGet()
        {
        }
    }
}
