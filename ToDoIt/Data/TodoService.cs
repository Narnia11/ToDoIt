using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Models;


namespace ToDoIt.Data
{
    class TodoService
    {
        //Person array not null or empty
        private static Todo[] todoArray = new Todo[0];

        public int Size()             //the method that return the length of the array.
        {
        return todoArray.Length;
        }


        public Todo[] FindAll()              //the method that return the Todo array.
        {
        return todoArray;

        }

        public Todo FindById(int personId)        //that return the person that has a matching personId as the passed in parameter.
        {
            foreach (Todo todo in todoArray)
        {
                if (personId == todo.Id)

                { return todo; }


        }
            return null;
        }

        public Todo AddTodo(string whatTodo)
        {
            Todo todo = new Todo(TodoSequencer.NextTodo(), whatTodo);
            Array.Resize(ref todoArray, todoArray.Length + 1);     // calling array resize method to increase the size by one
            todoArray[todoArray.Length - 1] = todo;      // the last index of array person
            return todo;
        }

        public void Clear()             //the method that clears all Person objects from the Person array.
        {
        Array.Clear(todoArray, 0, todoArray.Length);
        }


    }
}
