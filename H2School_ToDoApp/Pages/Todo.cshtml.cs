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
    public class TodoModel : PageModel
    {
        private readonly IRepository _context;        

        public TodoModel(IRepository context)
        {
            _context = context;
        }

        public IList<ToDo> ToDo { get; set; }

        public void OnGet()
        {
            ToDo = _context.GetAll();
        }
    }
}
