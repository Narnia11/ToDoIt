using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Models;
namespace ToDoIt.Data
{
    class PeopleService
    {
        //Person array not null or empty
        private static Person[] personArray = new Person[0];      

        public int Size()             //the method that return the length of the array.
        {
            return personArray.Length;
        }


        public Person[] FindAll()              //the method that return the Person array.
        {
            return personArray;

        }

        public Person FindById(int personId)        //that return the person that has a matching personId as the passed in parameter.
        {
            foreach (Person person in personArray)
            {
                if ( personId == person.Id)

                { return person; }


            }
             return null; 
        }
       
        public Person AddPerson(string firstName, string lastName)
        {
            Person person = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            Array.Resize(ref personArray, personArray.Length + 1);     // calling array resize method to increase the size by one
            personArray[personArray.Length - 1] = person;      // the last index of array person
            return person;
        }
        
        public void Clear()             //the method that clears all Person objects from the Person array.
        {
            Array.Clear(personArray, 0, personArray.Length);
        }
       
        
    }
}
