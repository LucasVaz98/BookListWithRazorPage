using BookListWithRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListWithRazor.Pages.BookList
{


    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db  = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.Books.AddAsync(Book); //this add the book to a queu that wil be pushed into the database
                await _db.SaveChangesAsync();  // this save into the database

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
