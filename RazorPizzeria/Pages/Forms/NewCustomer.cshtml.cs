using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class NewCustomerModel : PageModel
    {
        [BindProperty]

        public Customer csm { get; set; }

        private readonly ApplicationDbContext _context;

        public NewCustomerModel(ApplicationDbContext context)
        {
            _context= context;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _context.Customers.Add(csm);
            _context.SaveChanges();
            return RedirectToPage("/Customers", csm);
        }
    }
}
