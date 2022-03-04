using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Models
{
    class Person
    {
        private readonly int _id;   //field
        private string _firstName;  //field 
        private string _lastName;   //field

        public Person(int id, string firstName, string lastName)                //costructor
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;      
        }
        public string FirstName                //properties to read the first name
        {
            get
            {
                return _firstName;
            }
            set
            {
               
                if(string.IsNullOrWhiteSpace(value) || value.Length < 2)                //Prevent firstName from saving Empty or having less than 2 letters
                    throw new ArgumentException("First name must contain at least two letters!");
                _firstName = value;
            }
        }
        public string LastName                //properties to read the last name
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)                //Prevent lastName from saving Empty or having less than 2 letters
                    throw new ArgumentException("Last name must contain at least two letters!");
                _lastName = value;
            }
        }
        public int Id                //properties to read the id
        {
            get
            {
                return _id;
            }
         
        }
            public override string ToString()
        {
            return "Id: " + Id + "belongs to " + FirstName + LastName;
        }
    }

    
}
