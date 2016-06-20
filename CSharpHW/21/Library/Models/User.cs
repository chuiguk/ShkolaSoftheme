using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;

namespace Library.Models
{
    [Serializable]
    [ProtoContract]
    public class User
    {
        public User()
        {
                
        }
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        [Required(ErrorMessage = "User identificator was not specified")]
        [ProtoMember(1)]
        public string Name { get; set; }
        [Required(ErrorMessage = "User password identificator was not specified")]
        [ProtoMember(2)]
        public string Password { get; set; }
    }
}
