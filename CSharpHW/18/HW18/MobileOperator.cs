using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{


    class MobileOperator
    {
        List<MobileAccount> accounts = new List<MobileAccount>();
        public MobileOperator()
        {
            MobileAccount.CreatingNumber += CreatingAccount;
            MobileAccount.Call += CallHandle;
            MobileAccount.Message += MessageHandle;
        }
        void CallHandle(string callerNumber, string targetNumber)
        {
            bool numberExists = false;
            foreach (var acc in accounts)
            {
                if(targetNumber == acc.PhoneNumber)
                { 
                    acc.IncomingCall(callerNumber);
                    numberExists = true;
                }
            }
            if(!numberExists)
            { Console.WriteLine("Phone number not found!"); }
        }
        void MessageHandle(string senderNumber, string targetNumber, string message)
        {
            bool numberExists = false;
            foreach (var acc in accounts)
            {
                if (targetNumber == acc.PhoneNumber)
                {
                    acc.IncomingMessage(senderNumber, message);
                    numberExists = true;
                }
            }
            if (!numberExists)
            { Console.WriteLine("Phone number not found!"); }
        }
        void CreatingAccount(MobileAccount account)
        {
            foreach (var item in accounts)
            {
                if (item.PhoneNumber == account.PhoneNumber)
                {
                    throw new Exception("This phone number is already exists!");
                }
            }
            accounts.Add(account);
            Console.WriteLine("New user added!");
        }

    }
}

