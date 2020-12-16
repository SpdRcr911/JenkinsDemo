
using Sandbox.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.Data.Repositories
{
    public class PersonInMemoryRepository : IPersonRepository
    {
        private readonly List<Person> data = new List<Person> {
            new Person { Guid = Guid.Parse("8c11e999-c678-4aac-baa1-58b123733dc1"), Name = "Person One", Age = 10, Address = "Address 1" },
            new Person { Guid = Guid.Parse("de45c46f-346e-4b96-8ae3-13d6ced0d7ef"), Name = "Second Person", Age = 20, Address = "Address 2" },
            new Person { Guid = Guid.Parse("e0a65ca6-67a9-46af-a82b-d78ed4b4e852"), Name = "Last One" }
        };

        public Person Create(Person person)
        {
            data.Add(person);
            return person;
        }

        public Person Find(Guid guid)
        {
            return data.FirstOrDefault(d => d.Guid == guid);
        }

        public List<Person> GetAll()
        {
            return data;
        }

        public Person Update(Person person)
        {
            var personIndex = data.FindIndex(d => d.Guid == person.Guid);
            data[personIndex] = person;

            return data[personIndex];
        }
    }

}
