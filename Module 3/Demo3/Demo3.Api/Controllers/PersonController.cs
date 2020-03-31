using Demo3.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Demo3.Api.Controllers
{
    // 1. Add inheritance of ControllerBase
    // 2. Add attributes

    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        // 3. Create property and Models/Person.cs
        public IEnumerable<Person> People
        {
            get
            {
                var people = new List<Person>
                {
                    new Person(1, "Bob", "Smith", "34"),
                    new Person(2, "Jane", "Doe", "65"),
                    new Person(3, "Paul", "Lee", "20")
                };

                return people;
            }
        }

        // 4. Create endpoint to return all
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return People;
        }

        // 5. Create endpoint to return by Id
        [HttpGet("{id}")]
        public IEnumerable<Person> Get(int id)
        {
            return People.Where(q => q.Id == id);
        }
    }
}
