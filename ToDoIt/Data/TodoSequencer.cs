using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    class TodoSequencer
    {
        private static int todo = 0;


        public static int NextTodo()
        {

            return ++todo;

        }


        public static void Reset()
        {
            todo = 0;
        }

    }
}