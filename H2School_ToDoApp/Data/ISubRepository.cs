using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H2School_ToDoApp.Models;

namespace H2School_ToDoApp.Data
{
    public interface ISubRepository
    {
        public void AddCheckBox(CheckBox checkBox, int toDoId);
        public void UpdateCheckBox(CheckBox checkBox, int toDoId);
        public List<CheckBox> GetAllCheckBox(int toDoId);
        public void RemoveCheckBox(int toDoId);
    }
}
