using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace AgeConsole
{
    class AgeCount
    {
        DateTime _birthDate;
        int _age;
        string _zodiac;
        public void Count()
        {
            Console.WriteLine("Input your birth date (DD-MM-YYYY): ");
            string date = Console.ReadLine();
            if(!DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _birthDate))
            {
                Console.WriteLine("Incorrect input! Try again.");
                Count();
            }
            else
            {
                AgeCounter();
                Zodiac();
                Console.WriteLine("Your age: {0}, zodiac sign: {1}", _age, _zodiac);
            }
            
        }
        void AgeCounter()
        {
            DateTime now = DateTime.Now;
            _age = now.Year - _birthDate.Year;
            if (_birthDate.AddYears(_age) > now)
                _age--;
        }
        void Zodiac()
        {
            switch(_birthDate.Month)
            {
                case 1:
                    {
                        if (_birthDate.Day <= 19)
                            _zodiac = "Capricorn";
                        else
                            _zodiac = "Aquarius";
                        break;
                    }
                case 2:
                    {
                        if (_birthDate.Day <= 18)
                            _zodiac = "Aquarius";
                        else
                            _zodiac = "Pisces";
                        break;
                    }
                case 3:
                    {
                        if (_birthDate.Day <= 20)
                            _zodiac = "Pisces";
                        else
                            _zodiac = "Aries";
                        break;
                    }
                case 4:
                    {
                        if (_birthDate.Day <= 19)
                            _zodiac = "Aries";
                        else
                            _zodiac = "Taurus";
                        break;
                    }
                case 5:
                    {
                        if (_birthDate.Day <= 20)
                            _zodiac = "Taurus";
                        else
                            _zodiac = "Gemini";
                        break;
                    }
                case 6:
                    {
                        if (_birthDate.Day <= 21)
                            _zodiac = "Pisces";
                        else
                            _zodiac = "Cancer";
                        break;
                    }
                case 7:
                    {
                        if (_birthDate.Day <= 22)
                            _zodiac = "Cancer";
                        else
                            _zodiac = "Leo";
                        break;
                    }
                case 8:
                    {
                        if (_birthDate.Day <= 23)
                            _zodiac = "Leo";
                        else
                            _zodiac = "Virgo";
                        break;
                    }
                case 9:
                    {
                        if (_birthDate.Day <= 22)
                            _zodiac = "Virgo";
                        else
                            _zodiac = "Libra";
                        break;
                    }
                case 10:
                    {
                        if (_birthDate.Day <= 22)
                            _zodiac = "Libra";
                        else
                            _zodiac = "Scorpio";
                        break;
                    }
                case 11:
                    {
                        if (_birthDate.Day <= 21)
                            _zodiac = "Scorpio";
                        else
                            _zodiac = "Sagittarius";
                        break;
                    }
                case 12:
                    {
                        if (_birthDate.Day <= 21)
                            _zodiac = "Sagittarius";
                        else
                            _zodiac = "Capricorn";
                        break;
                    }
            }
        }
    }
}
