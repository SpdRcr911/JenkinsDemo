using Moq;
using NUnit.Framework;
using Sandbox.Data.Models;
using Sandbox.Data.Repositories;
using Sandbox.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.Tests
{
    public class PersonServiceTests
    {
        private Mock<IPersonRepository> mockPersonRepository = new Mock<IPersonRepository>();
        IPersonService personService;

        [SetUp]
        public void Setup()
        {
            personService = new PersonService(mockPersonRepository.Object);
        }

        [Test]
        public void When_GetAll_Return_All_Items_In_Repo()
        {
            mockPersonRepository.Setup(d => d.GetAll()).Returns((new Person[10]).ToList());

            var persons = personService.GetAllPerson();

            Assert.That(persons, Has.Count.EqualTo(10));
        }

        [Test]
        public void When_GetPerson_Return_Right_Person()
        {
            var myGuid = Guid.NewGuid();
            mockPersonRepository.Setup(d => d.Find(myGuid)).Returns(new Person { Guid = myGuid });

            var person = personService.GetPerson(myGuid);

            Assert.That(person.Guid, Is.EqualTo(myGuid));
        }
    }
}
