using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H2School_ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DeadLine { get; set; }
    }
}
