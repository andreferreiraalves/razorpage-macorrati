using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WAExemplo1.Models;

namespace WAExemplo1.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Cliente Cliente { get; set; }

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Clientes.Add(Cliente);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}