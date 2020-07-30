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
using System.Data.SqlTypes;
using System.Numerics;

namespace Task_1
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


        private void TextBox_NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TextBox_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Copy ||
                e.Command == ApplicationCommands.Cut ||
                e.Command == ApplicationCommands.Paste)
            {

                e.Handled = true;
            }
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                BtnCalc_Click(sender, null);
            }
        }

        private void BtnCalc_Click(object sender, RoutedEventArgs ea)
        {
            try
            {
                int n = int.Parse(TextInput.Text);
                BigInteger x = BigInteger.Pow(2, n);
                string res;

                if (CheckGroup.IsChecked == true)
                    res = x.ToString("#,##0");
                else
                    res = x.ToString();

                TextResult.Text += $"2 ^ {n} = " + res + Environment.NewLine;
            }
            catch (Exception)
            {
                TextResult.Text += "Не указана степень" + Environment.NewLine;
            }
        }
    }
}
