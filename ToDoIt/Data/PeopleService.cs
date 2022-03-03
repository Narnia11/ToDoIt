using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    class PeopleService
    {
            //Person array not null or empty
        private static Person[] personArray = new Person[0];      //?????????name of the array? is the aray written correctly?

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
            
            return Array.Find(personId);           //?????????????
        }


        /*e. Add a method that creates a new Person, adds the newly created object in the array and then return the created object. You have to “expand” the Person array. (tip: send in parameters needed to create the Person object and
use the PersonSequencer to give a unique personId)*/


        public void Clear()             //the method that clears all Person objects from the Person array.
        {
            Array.Clear(personArray, 0, personArray.Length);
        }
       
        
    }
}
