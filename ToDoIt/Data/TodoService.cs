using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Models;
namespace ToDoIt.Data
{
    class TodoService
    {
        private static Todo[] todoArray = new Todo[0];     //Todo array not null or empty

        public int Size()             //the method that return the length of the array.
        {
            return todoArray.Length;
        }


        public Todo[] FindAll()              //the method that return the Todo array.
        {
            return todoArray;

        }

        public Todo FindById(int todoId)        //that return the todo that has a matching todoId as the passed in parameter.
        {
            foreach (Todo todo in todoArray)
            {
                if (todoId == todo.Id)

                { return todo; }


            }
            return null;
        }

        public Todo AddTodo(string description)
        {
            Todo todo = new Todo(TodoSequencer.NextTodoId(), description);//call the Class Person and specify the needed variable of this class to use in this method
            Array.Resize(ref todoArray, todoArray.Length + 1);     // calling array resize method to increase the size by one
            todoArray[todoArray.Length - 1] = todo;               // the object inside the last index of array todo
            return todo;
        }

        public void Clear()             //the method that clears all todo objects from the todo array.
        {
            Array.Clear(todoArray, 0, todoArray.Length);
        }
        public Todo[] FindByDoneStatus(bool doneStatus)   //Returns array with objects that has a matching done status.
        {
            List<String> doneTodo = new List<string>();

            foreach (Todo todo in todoArray)
            {
                if (doneStatus == todo.Done)
                {
                    return todoArray;
                }
            }
            return null;
        }

        public Todo[] FindByAssignee(int personId)     //Returns array with ToDo ́s that has an assignee with a matching id 
        {
            //add list
            foreach (Todo todo in todoArray)
            {
                if (personId == todo.Assignee.Id)
                {
                    return todoArray;
                }
            }
            return null;
        }
        public Todo[] FindByAssignee(Person assignee)    //Returns array with ToDo ́sthat has this Person as its assignee
        {

            return FindByAssignee(assignee.Id);
        }
        public Todo[] FindUnassignedTodoItems()    //Returns an array of ToDo ́s that does not have an assignee set to it.
        {    //add list

            foreach (Todo todo in todoArray)
            {
                if (todo.Assignee == null)
                {
                    return todoArray;
                }
            }
            return null;
        }
        

        public Todo MinusTodo()
        {
            for (int indexToDelet = todoArray.Length - 1; indexToDelet >= 0; indexToDelet--)
            {
                Array.Resize(ref todoArray, todoArray.Length + 1);

                 todoArray[indexToDelet] = null;
               
            }
            return todoArray;
        }
    }
}

 