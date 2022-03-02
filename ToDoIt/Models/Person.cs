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
               
                if(string.IsNullOrWhiteSpace(value))                //Prevent firstName from saving Empty
                    throw new ArgumentException("Please specify first name!");
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
                if (string.IsNullOrWhiteSpace(value))                //Prevent lastName from saving Empty & Null
                    throw new ArgumentException("Please specify last name!");
                _lastName = value;
            }
        }
        public int Id                //properties to read the Id
        {
            get
            {
                return _Id;
            }
         
        }
            public override string ToString()
        {
            return "Id: " + Id + "belongs to " + firstName + lastName;
        }
    }

    
}
