using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Models;

namespace TodoIt.Tests.Models
{
    public class PersonTests
    {
        [Fact]
        public void PersonConstructorTest()
        {
            //Arrange
            string fistName = "Narges";
            string lastName = "Hekmatnia";
            int id = 777;

            //Act
            Person result = new Person(id, fistName, lastName);

            //Asert
            Assert.NotNull(result);
            Assert.Equal(fistName, result.FirstName);
            Assert.Equal(lastName, result.LastName);
            Assert.NotEqual(0, result.Id);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]

        public void NullOrEmptyTest(string firstName)
        {
            //Arange
            int id = 777;
            string badfirstName = null;
            string lastName = "Hekmatnia";
            Person person = new Person(id,"safeFirstName", lastName);

            //Act & Assert are the same 
            Assert.Throws<ArgumentException>(() => person.FirstName = badfirstName);

        }       
    }
}
