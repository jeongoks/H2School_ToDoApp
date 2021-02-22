using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H2School_ToDoApp.Models;

namespace H2School_ToDoApp.Data
{
    public interface IRepository
    {
        // Get All To Do Lists.
        List<ToDo> GetAll();
        // Get a To Do List by its Id
        ToDo GetItemById(int? id);
        // Create a new To Do List
        void Create(ToDo newTodo);
        // Update a To Do List
        void Update(ToDo newToDo);
        // Remove a To Do List
        void Remove(int id);
    }
}
