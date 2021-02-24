using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using H2School_ToDoApp.Models;
using H2School_ToDoApp.Data;

namespace H2School_ToDoApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IRepository _context;

        public CreateModel(IRepository context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ToDo ToDo { get; set; }

        public IActionResult OnPost()
        {
            // Creating our To Do
            _context.Create(ToDo);
            return RedirectToPage("./ToDo");
        }
    }
}
