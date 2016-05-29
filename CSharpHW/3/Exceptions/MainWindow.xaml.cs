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

namespace Exceptions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _rand = new Random();
        int _number;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            _number = _rand.Next(10);
            try
            {
                if (_number == Convert.ToInt32(textBox.Text))
                {
                    answerBlock.Text = "Sucsess!";
                }
                else
                {
                    throw new Exception("Wrong!");
                }
            }
            catch (FormatException ex)
            {
                answerBlock.Text = ex.Message;
            }
            catch(Exception ex)
            {
                answerBlock.Text = ex.Message;
            }
        }
    }
}
