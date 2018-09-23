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

namespace BaseConversionApp
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {          
            try
            {
                int base10Number = int.Parse(inputBox.Text);

                if (baseTwoButton.IsChecked.HasValue && baseTwoButton.IsChecked.Value)
                {
                    resultBox.Text = toBinary(base10Number);    
                }
                else if (baseSixButton.IsChecked.HasValue && baseSixButton.IsChecked.Value)
                {
                    resultBox.Text = toSenary(base10Number);
                }
                else if (baseEightButton.IsChecked.HasValue && baseEightButton.IsChecked.Value)
                {
                    resultBox.Text = toOctal(base10Number);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "";
            resultBox.Text = "";
        }

        private string toBinary(int n)
        {
            string digit = "";

            while (n != 0)
            {
                string temp = (n % 2).ToString();
                n = n / 2;
                digit += temp;
            }

            return Operations.reverse(digit);
        }

        private string toSenary(int n)
        {
            string digit = "";

            while(n != 0)
            {
                string temp = (n % 6).ToString();
                n = n / 6;
                digit += temp;
            }
            
            return Operations.reverse(digit);
        }

        private string toOctal(int n)
        {
            string digit = "";

            while (n != 0)
            {
                string temp = (n % 8).ToString();
                n = n / 8;
                digit += temp;
            }

            return Operations.reverse(digit);
        }
    }
}
