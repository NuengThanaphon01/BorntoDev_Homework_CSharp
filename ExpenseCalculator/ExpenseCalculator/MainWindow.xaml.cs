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

namespace ExpenseCalculator
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double inCOme, exPEnse, prIce,day;

            inCOme = Convert.ToDouble(txtIncome.Text);
            exPEnse = Convert.ToDouble(txtExpense.Text);
            prIce = Convert.ToDouble(txtPrice.Text);
            if(inCOme>exPEnse)
            {
                day = prIce / (inCOme - exPEnse);
                txtResult.Text = Math.Ceiling(day).ToString();
            }
            else if (inCOme<exPEnse)
            {
                MessageBox.Show("คุณมีรายจ่ายมากกว่ารายรับ ควรหารายได้เสริมอีกช่องทาง!!");
            }
            else if (inCOme == exPEnse)
            {
                MessageBox.Show("รายรับและรายจ่ายคุณเท่ากัน ควรหารายได้เสริมอีกช่องทาง!!");
            }

        }

        private void txtIncome_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtExpense_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
