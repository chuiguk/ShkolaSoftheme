using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRegistration
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ? BirthDate { get; set; }
        public Genders ? Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Info { get; set; }
        public User(string firstName, string lastName, DateTime ? birthDate, Genders ? gender, string email, string phone, string info)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Email = email;
            this.Phone = phone;
            this.Info = info;
        }
    }
}
