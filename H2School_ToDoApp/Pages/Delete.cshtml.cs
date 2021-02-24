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
    public class DeleteModel : PageModel
    {
        private readonly IRepository _context;

        public DeleteModel(IRepository context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDo ToDo { get; set; }

        public IActionResult OnGet(int? id)
        {
            // Checking if the Id or To Do is null or not.
            if (id == null)
            {
                return NotFound();
            }

            ToDo = _context.GetItemById(id);

            if (ToDo == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDo = _context.GetItemById(id);

            // If ToDo isn't the same as null, then Remove it from the ToDo List
            if (ToDo != null)
            {
                _context.Remove(ToDo.Id);
            }

            return RedirectToPage("./ToDo");
        }
    }
}
