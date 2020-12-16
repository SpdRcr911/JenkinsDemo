using Sandbox.Data.Models;
using Sandbox.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Sandbox.Data.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public Person GetPerson(Guid guid)
        {
            var person = personRepository.Find(guid);
            return person;
        }

        public List<Person> GetAllPerson()
        {
            var persons = personRepository.GetAll();
            return persons;
        }
    }
}
