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

namespace NumericDataTypes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedItem = DataTypeListBox.SelectedItem as ListBoxItem;
            switch (selectedItem.Content.ToString())
            {
                case "Byte":
                    Byte();
                    break;
                case "SByte":
                    SByte();
                    break;
                case "Short":
                    Short();
                    break;
                case "UShort":
                    UShort();
                    break;
                case "Int":
                    Int();
                    break;
                case "UInt":
                    UInt();
                    break;
                case "Long":
                    Long();
                    break;
                case "ULong":
                    ULong();
                    break;
                case "Float":
                    Float();
                    break;
                case "Double":
                    Double();
                    break;
                case "Decimal":
                    Decimal();
                    break;
            }
        }
        void Byte()
        {
            MinTextBox.Text = byte.MinValue.ToString();
            MaxTextBox.Text = byte.MaxValue.ToString();
            DefaultTextBox.Text = new byte().ToString();
        }
        void SByte()
        {
            MinTextBox.Text = sbyte.MinValue.ToString();
            MaxTextBox.Text = sbyte.MaxValue.ToString();
            DefaultTextBox.Text = new sbyte().ToString();
        }
        void Short()
        {
            MinTextBox.Text = short.MinValue.ToString();
            MaxTextBox.Text = short.MaxValue.ToString();
            DefaultTextBox.Text = new short().ToString();
        }
        void UShort()
        {
            MinTextBox.Text = ushort.MinValue.ToString();
            MaxTextBox.Text = ushort.MaxValue.ToString();
            DefaultTextBox.Text = new ushort().ToString();
        }
        void Int()
        {
            MinTextBox.Text = int.MinValue.ToString();
            MaxTextBox.Text = int.MaxValue.ToString();
            DefaultTextBox.Text = new int().ToString();
        }
        void UInt()
        {
            MinTextBox.Text = uint.MinValue.ToString();
            MaxTextBox.Text = uint.MaxValue.ToString();
            DefaultTextBox.Text = new uint().ToString();
        }
        void Long()
        {
            MinTextBox.Text = long.MinValue.ToString();
            MaxTextBox.Text = long.MaxValue.ToString();
            DefaultTextBox.Text = new long().ToString();
        }
        void ULong()
        {
            MinTextBox.Text = ulong.MinValue.ToString();
            MaxTextBox.Text = ulong.MaxValue.ToString();
            DefaultTextBox.Text = new ulong().ToString();
        }
        void Float()
        {
            MinTextBox.Text = float.MinValue.ToString();
            MaxTextBox.Text = float.MaxValue.ToString();
            DefaultTextBox.Text = new float().ToString();
        }
        void Double()
        {
            MinTextBox.Text = double.MinValue.ToString();
            MaxTextBox.Text = double.MaxValue.ToString();
            DefaultTextBox.Text = new double().ToString();
        }
        void Decimal()
        {
            MinTextBox.Text = decimal.MinValue.ToString();
            MaxTextBox.Text = decimal.MaxValue.ToString();
            DefaultTextBox.Text = new decimal().ToString();
        }

    }
}
