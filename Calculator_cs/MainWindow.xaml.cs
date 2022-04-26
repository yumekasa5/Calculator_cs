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

namespace Calculator_cs
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

        private void AC_Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)ResultLabel.Content != "0")
            {
                ResultLabel.Content = "0";
            }
            
        }

        private void Input1_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "1" ;
                ResultLabel.Content = result_calc;
            }else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "1";
            }
        }

        private void Input2_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "2";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "2";
            }
        }

        private void Input3_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "3";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "3";
            }
        }

        private void Input0_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "0";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "0";
            }
        }

        private void Input6_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "6";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "6";
            }
        }

        private void Input7_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "7";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "7";
            }
        }

        private void Input8_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "8";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "8";
            }
        }

        private void Input9_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "9";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "9";
            }
        }

        private void Input4_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "4";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "4";
            }
        }

        private void Input5_Button_Click(object sender, RoutedEventArgs e)
        {
            string result_calc = (string)ResultLabel.Content;
            if (result_calc != "0") //ResultLabelが0以外
            {
                result_calc += "5";
                ResultLabel.Content = result_calc;
            }
            else if (result_calc == "0") //ResultLabelが0のとき
            {
                ResultLabel.Content = "5";
            }
        }
    }
}
