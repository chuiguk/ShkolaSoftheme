using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Library.Models
{
    public class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        [Required(ErrorMessage = "User identificator was not specified")]
        public string Name { get; set; }
        [Required(ErrorMessage = "User password identificator was not specified")]
        public string Password { get; set; }
    }
}
