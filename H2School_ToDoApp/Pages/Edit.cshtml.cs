using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using H2School_ToDoApp.Data;
using H2School_ToDoApp.Models;

namespace H2School_ToDoApp.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepository _context;

        public EditModel(IRepository context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDo ToDo { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDo = _context.GetItemById(id.Value);

            if (ToDo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            _context.Update(ToDo);

            return RedirectToPage("./ToDo");
        }

        private bool ToDoExists(int id)
        {
            ToDo todo = _context.GetItemById(id);

            if (todo != null)
            {
                return true;
            }
            return false;
        }
    }
}
