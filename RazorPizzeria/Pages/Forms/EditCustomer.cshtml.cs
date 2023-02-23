using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class EditCustomerModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditCustomerModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer csm { get; set; }

        public void OnGet(int id)
        {
            if(id !=null)
            {
                var data = (from customer in _context.Customers
                            where customer.Id == id
                            select customer).SingleOrDefault();

                csm = data;
            }
        }
        public IActionResult OnPost()
        {
            var customer = csm;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Entry(csm).Property(x => x.Name).IsModified= true;
            _context.Entry(csm).Property(x => x.Address).IsModified = true;
            _context.Entry(csm).Property(x => x.City).IsModified = true;
            _context.Entry(csm).Property(x => x.Email).IsModified = true;
            _context.Entry(csm).Property(x => x.Phone).IsModified = true;
            _context.SaveChanges();
            return RedirectToPage("/Customers");
        }
    }
}
