using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    class TodoSequencer
    {
        private static int todoId;
        static int idCounter = 0;
        int id;
        public static int NextTodoId { get { return idCounter; } }


        public static int Reset { get { return todoId = 0; } }

    }
}