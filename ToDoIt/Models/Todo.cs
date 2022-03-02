using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Models
{
    class Todo
    {
        private readonly int _id;   //field
        private string _description;  //field 
        private string _done;   //field
        private Person _assignee;     //field

        public Todo(int id, string description)                //costructor
        {

        }
        public int id           //properties to read the Id
        {
            get
            {
                return _id;
            }

        }
        public string description           //properties to read the description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public string done           //properties to read the done
        {
            get
            {
                return _done;
            }
            set
            {
                _done = value;
            }
        }
        public Person assignee           //properties to read the assignee
        {
            get
            {
                return _assignee;
            }
            set
            {
                _assignee = value;
            }
        }
    }
}
