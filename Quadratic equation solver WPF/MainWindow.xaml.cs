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

namespace Quadratic_equation_solver_WPF
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

        private void Button_calculate_Click(object sender, RoutedEventArgs e)
        {

            //string InputLength, IndexOfTheFirstComma, IndexOfTheSecondComma;
            string[] SplitString;
            double a, b, c;

            //InputLength = TextBox_input.Text;
            //IndexOfTheFirstComma = TextBox_input.Text.IndexOf(",").ToString();
            //IndexOfTheSecondComma = TextBox_input.Text.LastIndexOf(",").ToString();
            SplitString = TextBox_input.Text.Split(new Char[] { ',' });
            a = double.Parse(SplitString[0]);
            b = double.Parse(SplitString[1]);
            c = double.Parse(SplitString[2]);

            Label_results.Content = a;

            


            
        }
    }
}
