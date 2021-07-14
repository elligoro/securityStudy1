using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.db
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime UpdatedDt { get; set; } 
    }
}
