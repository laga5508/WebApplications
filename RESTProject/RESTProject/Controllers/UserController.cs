using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using RESTProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class UserController : ControllerBase
    {
        public static List<Users> users = new List<Users>();
        public static int currentId = 1001;
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Users Get(int id)
        {
            var contact = users.FirstOrDefault(t => t.Id == id);
            return contact;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] Users value)
        {
            value.Id = currentId++;
            value.DateAdded = DateTime.Now;
           
            users.Add(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Users value)
        {
            var user = users.FirstOrDefault(t => t.Id == id);
            user.Id = id;
            user.Email = value.Email;
            user.Password = value.Password;      
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            users.RemoveAll(t=> t.Id==id);
        }
    }
}
