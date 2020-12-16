using System;

namespace Sandbox.Data.Models
{
    public class Person : IPerson
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
