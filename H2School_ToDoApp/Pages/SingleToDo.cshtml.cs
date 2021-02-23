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
    public class SingleToDoModel : PageModel
    {
        private readonly IRepository _context;

        public SingleToDoModel(IRepository context)
        {
            _context = context;
        }

        public ToDo ToDo { get; set; }

        public IActionResult OnGet(int id)
       {
            ToDo = _context.GetItemById(id);
            return Page();
        }
    }
}
