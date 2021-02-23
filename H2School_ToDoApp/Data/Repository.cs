using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H2School_ToDoApp.Data;
using H2School_ToDoApp.Models;

namespace H2School_ToDoApp.Data
{
    public class Repository : IRepository, ISubRepository
    {
        private List<ToDo> todos;

        public Repository()
        {
            todos = new List<ToDo>
            {
                new ToDo{ Id=1, Title="Shopping List", Description="Listing down what I need to buy at the store.", DeadLine=2}
            };
        }

        /// <summary>
        /// Creating a new To Do List.
        /// </summary>
        /// <param name="newTodo"></param>
        public void Create(ToDo newTodo)
        {
            newTodo.Id = todos.Max(t => t.Id);
            ++newTodo.Id;
            todos.Add(newTodo);
        }

        /// <summary>
        /// Updating / Editing a To Do List.
        /// </summary>
        /// <param name="newTodo"></param>
        public void Update(ToDo newTodo)
        {
            int index = todos.FindIndex(t => t.Id == newTodo.Id);
            todos[index].Title = newTodo.Title;
        }

        /// <summary>
        /// Getting all of the To Do Lists.
        /// </summary>
        /// <returns></returns>
        public List<ToDo> GetAll()
        {
            return todos;
        }

        /// <summary>
        /// Finding a To Do List by its Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ToDo GetItemById(int? id)
        {
            return todos.SingleOrDefault(t => t.Id == id);
        }

        /// <summary>
        /// Removing a To Do from the List.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            todos.Remove(GetItemById(id));
        }


        public void AddCheckBox(CheckBox checkBox, int toDoId)
        {
            checkBox.Id = todos[toDoId].ListOfCheckBox.Max(t => t.Id);
            ++checkBox.Id;
            todos[toDoId].ListOfCheckBox.Add(checkBox);
        }

        public void UpdateCheckBox(CheckBox checkBox, int toDoId)
        {
            int index = todos[toDoId].ListOfCheckBox.FindIndex(t => t.Id == checkBox.Id);
            todos[toDoId].ListOfCheckBox[index] = checkBox;
        }

        public List<CheckBox> GetAllCheckBox(int toDoId)
        {
            return todos[toDoId].ListOfCheckBox;
        }

        public void RemoveCheckBox(int toDoId)
        {
            
        }
    }
}
