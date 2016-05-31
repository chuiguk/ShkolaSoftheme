using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClass
{
    class Human
    {
        DateTime _birthDate;
        string _name;
        string _lastName;
        readonly int _age;
        public DateTime BirthDate
        {
            get { return _birthDate; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public int Age
        {
            get { return _age; }
        }
        public Human(DateTime birthDate, string name, string lastName, int age)
        {
            this._birthDate = birthDate;
            this._name = name;
            this._lastName = lastName;
            this._age = age;
        }
        public Human(DateTime birthDate, string name, string lastName)
        {
            this._birthDate = birthDate;
            this._name = name;
            this._lastName = lastName;
            DateTime now = DateTime.Now;
            _age = now.Year - _birthDate.Year;
            if (_birthDate.AddYears(_age) > now)
            {
                _age--;
            }
        }
        public override bool Equals(object obj)
        {
            var human = obj as Human;
            if (human.Name == this.Name && human.LastName == this.LastName && human.BirthDate == this.BirthDate && human.Age == this.Age)
            { 
                return true; 
            }
            return false;
        }
    }
}
