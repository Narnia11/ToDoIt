using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Models
{
    class Person
    {
        private readonly int _Id;   //field
        private string _firstName;  //field 
        private string _lastName;   //field

        public Person(int Id, string firstname, string lastname)                //costructor
        {
            _Id = Id;
            _firstName = firstname;
            _lastName = lastname;      
        }
        public string firstName                //properties to read the first name
        {
            get
            {
                return _firstName;
            }
            set
            {               
                if(value == null || value.Contains(" "))                //Prevent firstName from saving Empty
                    throw new Exception("Please specify first name!");
                _firstName = value;
            }
        }
        public string lastName                //properties to read the last name
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == null || value.Contains(" "))                //Prevent lastName from saving Empty & Null
                    throw new Exception("Please specify last name!");
                _lastName = value;
            }
        }
        public readonly int Id                //properties to read the Id
        {
            get
            {
                return _Id;
            }
         /* set
            {
                _Id = value;                //???????????int _Id is a readonly field, how can I solv the problem?
            }  */
        }
            public override string ToString()
        {
            return "Id: " + Id + "belongs to " + firstName + lastName;
        }
    }

    
}
