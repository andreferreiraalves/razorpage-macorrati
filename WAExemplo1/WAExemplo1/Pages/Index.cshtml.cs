using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WAExemplo1.Models;

namespace WAExemplo1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;
        public IList<Cliente> Clientes { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public async Task OnGetAsync()
        {
            Clientes = await _context.Clientes.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _context.Clientes.FindAsync(id);
            if(contact != null)
            {
                _context.Clientes.Remove(contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public IActionResult OnPostTeste(Cliente c)
        {
            Console.WriteLine(c.Nome);
            return RedirectToPage();
        }
    }
}
