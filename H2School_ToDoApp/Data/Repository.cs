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
            if (todos == null)
            {
                todos = new List<ToDo>
                {
                    new ToDo{ Id=0, Title="Shopping List", Description="Ingridients to Pitabread", DeadLine=2}
                };
            }
        }

        /// <summary>
        /// Creating a new To Do List.
        /// </summary>
        /// <param name="newTodo"></param>
        public void Create(ToDo newTodo)
        {
            if (todos.Count == 0)
            {
                newTodo.Id = 0;
            }
            else
            {
                newTodo.Id = todos.Max(t => t.Id);
            }
            ++newTodo.Id;
            todos.Add(newTodo);

        }

        /// <summary>
        /// Updating / Editing a To Do List.
        /// </summary>
        /// <param name="newTodo"></param>
        public void Update(ToDo newTodo)
        {
            // Remember to add all of the Objects in from the List, to be able to Edit them.
            int index = todos.FindIndex(t => t.Id == newTodo.Id);
            todos[index].Title = newTodo.Title;
            todos[index].Description = newTodo.Description;
            todos[index].DeadLine = newTodo.DeadLine;
            todos[index].Complete = newTodo.Complete;
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


        /// <summary>
        /// This is where we Add a Check Box to our List of Checkboxs in ToDo
        /// </summary>
        /// <param name="checkBox"></param>
        /// <param name="toDoId"></param>
        public void AddCheckBox(CheckBox checkBox, int toDoId)
        {
            if (todos[toDoId].ListOfCheckBox.Count != 0)
            {
                checkBox.Id = todos[toDoId].ListOfCheckBox.Max(t => t.Id);
                ++checkBox.Id;
            }
            else
            {
                checkBox.Id = 0;
            }
            
            todos[toDoId].ListOfCheckBox.Add(checkBox);
        }

        /// <summary>
        /// This is where we update a specific CheckBox.
        /// </summary>
        /// <param name="checkBox"></param>
        /// <param name="toDoId"></param>
        public void UpdateCheckBox(CheckBox checkBox, int toDoId)
        {
            int index = todos[toDoId].ListOfCheckBox.FindIndex(t => t.Id == checkBox.Id);
            todos[toDoId].ListOfCheckBox[index] = checkBox;
        }

        /// <summary>
        /// Here we're retrieving all of our CheckBoxes.
        /// </summary>
        /// <param name="toDoId"></param>
        /// <returns></returns>
        public List<CheckBox> GetAllCheckBox(int toDoId)
        {
            return todos[toDoId].ListOfCheckBox;
        }

        public void RemoveCheckBox(int toDoId)
        {
            
        }
    }
}
