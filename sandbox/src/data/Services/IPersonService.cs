using Sandbox.Data.Models;
using System;
using System.Collections.Generic;

namespace Sandbox.Data.Services
{
    public interface IPersonService
    {
        List<Person> GetAllPerson();
        Person GetPerson(Guid guid);
    }
}