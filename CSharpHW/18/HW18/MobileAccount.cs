using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    delegate void CelluarHandle(string callerNumber, string targetNumber);
    delegate void AddingAccountDelegate(MobileAccount sender);
    delegate void MessageHandle(string callerNumber, string targetNumber, string message);
    class MobileAccount
    {
        Dictionary<string, string> contacts;
        public string PhoneNumber { get; private set; }

        public static event AddingAccountDelegate CreatingNumber;

        public static event CelluarHandle Call;

        public static event MessageHandle Message;

        public MobileAccount(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            CreatingNumber(this);
            contacts = new Dictionary<string, string> 
            {
                {"+380636419975", "Eugene"},
                {"+380933994597", "Vlad"}
            };
        }
       
        public void MakeACall(string number)
        {
            Call(this.PhoneNumber, number);
        }
        public void SendMessage(string number, string message)
        {
            Message(this.PhoneNumber, number, message);
        }
        public void IncomingCall(string number)
        {
            if (contacts.ContainsKey(number))
            {
                Console.WriteLine("{0}, {1} calls you!", this.PhoneNumber, contacts[number]);
            }
            else
            {
                Console.WriteLine("{0}, {1} calls you!", this.PhoneNumber, number);
            }
        }
        public void IncomingMessage(string number, string message)
        {
            if (contacts.ContainsKey(number))
            {
                Console.WriteLine("{0}, You got message from {1}: {2}", this.PhoneNumber, contacts[number], message);
            }
            else
            {
                Console.WriteLine("{0}, You got message from {1}: {2}", this.PhoneNumber, number, message);
            }           
        }
    }
}
