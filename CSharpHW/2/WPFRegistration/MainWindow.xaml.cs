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
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace WPFRegistration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _userName;
        string _userLastName;
        DateTime ? _userBirthDate;
        Genders ? _userGender;
        string _userEmail;
        string _userPhone;
        string _userAdditionalInfo;
        List<User> _users= new List<User>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void genderMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _userGender = null;
            genderMenu.IsDropDownOpen = false;
            if (genderMenu.SelectedValue == genderMale)
            {
                _userGender = Genders.Male;
            }
            if (genderMenu.SelectedValue == genderFemale)
            {
                _userGender = Genders.Female;
            }
        }

        private void genderMale_Click(object sender, RoutedEventArgs e)
        {
            genderMenu.SelectedItem = genderMale;
        }

        private void genderFemale_Click(object sender, RoutedEventArgs e)
        {
            genderMenu.SelectedItem = genderFemale;
            
        }
        private void nameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            _userName = null;
            nameError.Text = null;
            Regex nameCheck = new Regex(@"^[a-zA-Z]{2,255}$");
            if (nameCheck.IsMatch(nameBox.Text))
            {
                _userName = nameBox.Text;
            }
            else if (nameBox.Text == "") { }
            else
            {
                nameError.Text = "Wrong name input!";
            }
        }
        private void lastNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            _userLastName = null;
            lastNameError.Text = null;
            Regex lastNameCheck = new Regex(@"^[a-zA-Z]{2,255}$");
            if (lastNameCheck.IsMatch(lastNameBox.Text))
            {
                _userLastName = lastNameBox.Text;
            }
            else if (lastNameBox.Text == "") { }
            else
            {
                lastNameError.Text = "Wrong name input!";
            }
        }
        private void SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            _userBirthDate = null;
            if (datePicker.SelectedDate.Value.Year > 1900 && datePicker.SelectedDate.Value.Year <= DateTime.Now.Year)
            {
                _userBirthDate = DateTime.Parse(datePicker.SelectedDate.Value.ToShortDateString());
            }
            else
            {
                dateError.Text = "Wrong birth date!";
            }
        }

        private void emailBox_LostFocus(object sender, RoutedEventArgs e)
        {
            _userEmail = null;
            if (EmailValidation(emailBox.Text))
            {
                _userEmail = emailBox.Text;
            }
            else if (emailBox.Text == "") { }
            else
            {
                emailError.Text = "Wrong e-mail input!";
            }
        }
        private bool EmailValidation(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void phoneBox_LostFocus(object sender, RoutedEventArgs e)
        {
            _userPhone = null;
            nameError.Text = null;
            Regex phoneCheck = new Regex(@"^[0-9]{12}$");
            if (phoneCheck.IsMatch(phoneBox.Text))
            {
                _userPhone = phoneBox.Text;
            }
            else if (phoneBox.Text == "") { }
            else
            {
                phoneError.Text = "Wrong phone input!";
            }
        }

        private void additionalBox_LostFocus(object sender, RoutedEventArgs e)
        {
            infoError.Text = null;
            _userAdditionalInfo = null;
            string additional = additionalBox.Text;
            if (additional.Length < 2000)
            {
                _userAdditionalInfo = additional;
            }
            else
            {
                infoError.Text = "Additional info is too big!";
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            answerBlock.Text = null;
            if (_userName != null && _userLastName != null && _userBirthDate != null && _userGender != null && _userEmail != null && _userPhone != null && _userAdditionalInfo != null)
            {
                _users.Add(new User(_userName, _userLastName, _userBirthDate, _userGender, _userEmail, _userPhone, _userAdditionalInfo));
                answerBlock.Text = "User successfully added!";
            }
            else
            {
                answerBlock.Text = "Please fill all form!";
            }
        }

        private void phoneBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            phoneError.Text = null;
        }

        private void emailBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            emailError.Text = null;
        }







       


    }
}
