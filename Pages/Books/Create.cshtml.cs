using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hritcu_DragosCristian_Lab2.Data;
using Hritcu_DragosCristian_Lab2.Models;

namespace Hritcu_DragosCristian_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Hritcu_DragosCristian_Lab2.Data.Hritcu_DragosCristian_Lab2Context _context;

        public CreateModel(Hritcu_DragosCristian_Lab2.Data.Hritcu_DragosCristian_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
