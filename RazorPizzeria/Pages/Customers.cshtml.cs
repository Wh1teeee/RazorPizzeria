using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class CustomersModel : PageModel
    {
        public List<Customer> Customers = new List<Customer>();

        private readonly ApplicationDbContext _context;

        public CustomersModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            Customers = _context.Customers.ToList();
        }

        public IActionResult OnGetDelete(int id)
        {
            if(id != null)
            {
                var data = _context.Customers.Find(id);
                _context.Customers.Remove(data);
                _context.SaveChanges();
            }
            return RedirectToPage("/Customers");
        }
    }
}
