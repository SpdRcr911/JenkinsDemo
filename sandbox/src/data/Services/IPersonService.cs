using Sandbox.Data.Models;
using System;
using System.Collections.Generic;

namespace Sandbox.Data.Services
{
    public interface IPersonService
    {
        List<Person> GetAllPersons();
        Person GetPerson(Guid guid);
    }
}