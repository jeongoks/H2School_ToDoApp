using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using H2School_ToDoApp.Models;

namespace H2School_ToDoApp.Pages
{
    public class TodoModel : PageModel
    {
        public List<ToDo> NewToDo { get; set; }

        public void OnGet()
        {

        }
    }
}
