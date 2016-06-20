using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Library.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    class BookAtribbute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            ErrorMessage = "You cant take books!";
            return false;
        }
    }
}
