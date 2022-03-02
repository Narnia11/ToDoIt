using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    class PersonSequencer
    {
        private static int personId;        
        static int idCounter = 0;
        int id;
        public static int NextPersonId { get { return idCounter; } }
        
        
        public static int Reset { get { return personId = 0; } }
        
    }
}
