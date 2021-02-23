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
    public class CreateCheckBoxModel : PageModel
    {
        private readonly IRepository _todoContext;
        private readonly ISubRepository _checkboxContext;

        public CreateCheckBoxModel(IRepository todoContext, ISubRepository checkboxContext)
        {
            _todoContext = todoContext;
            _checkboxContext = checkboxContext;
        }

        [BindProperty]
        public ToDo ToDo { get; set; }

        public IActionResult OnGet(int id)
        {
            ToDo = _todoContext.GetItemById(id);
            return Page();
        }

        [BindProperty]
        public CheckBox CheckBox { get; set; }

        public IActionResult OnPost(int id)
        {
            _checkboxContext.AddCheckBox(CheckBox, id);
            return RedirectToPage("./ToDo");
        }
    }
}
