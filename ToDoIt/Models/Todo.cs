using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Models
{
    class Todo
    {
        private readonly int _id;   //field
        private string _description;  //field 
        private bool _done;   //field
        private Person _assignee;     //field

        public Todo(int id, string description)                //costructor
        {

        }
        public int Id           //properties to read the Id
        {
            get
            {
                return _id;
            }

        }
        public string Description           //properties to read the description
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
        public bool Done           //properties to read the done
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
        public Person Assignee           //properties to read the assignee
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
