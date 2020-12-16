using Sandbox.Data.Models;
using System;
using System.Collections.Generic;

namespace Sandbox.Data.Repositories
{
    public interface IPersonRepository
    {
        Person Find(Guid guid);
        List<Person> GetAll();
        Person Create(Person person);
        Person Update(Person person);
    }
}