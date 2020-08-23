using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTProject.Models
{
    public class Users
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
