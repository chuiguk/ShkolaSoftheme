﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new UserDataBase();
            users.Authorisation();
            Console.ReadKey();
        }
    }
}