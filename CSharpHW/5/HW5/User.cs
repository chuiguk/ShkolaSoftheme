using System;

namespace HW5
{
    class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public User(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
