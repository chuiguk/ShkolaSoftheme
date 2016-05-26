using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.IO;
namespace AgeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime _birthDate;
        int _age;
        string _zodiac;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string date = DateBlock.Text + "-" + MonthBlock.Text + "-" + YearBlock.Text;
            if (!DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _birthDate))
            {
                AnswerBlock.Text = "Incorrect input! Try again!.";
            }
            else
            {
                AgeCounter();
                Zodiac();
                try
                {
                    string path = _zodiac + ".png";
                    Uri imageUri = new Uri(System.IO.Path.GetFullPath(path), UriKind.Absolute);
                    BitmapImage imageBitmap = new BitmapImage(imageUri);
                    ZodiacImg.Source = imageBitmap;
                }
                catch { }
                AnswerBlock.Text = String.Format("Your age: {0}, zodiac sign: {1}", _age, _zodiac);
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
            switch (_birthDate.Month)
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MonthBlock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void YearBlock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
