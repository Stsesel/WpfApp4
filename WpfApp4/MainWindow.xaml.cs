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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDollar = rateDollar * sumDollar;
            resSum1.Text = resDollar.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resEuro = rateEuro * sumEuro;
            resSum2.Text = resEuro.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate3.Text);
            double sumGriv = Convert.ToDouble(sum3.Text);
            double resGriv = rateGriv * sumGriv;
            resSum3.Text = resGriv.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate4.Text);
            double sumDram = Convert.ToDouble(sum4.Text);
            double resGriv = rateDram * sumDram;
            resSum4.Text = resGriv.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rate5.Text);
            double resInch = rateInch * 0.0254;
            resSum5.Text = resInch.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double rateFoot = Convert.ToDouble(rate6.Text);
            double resFoot = rateFoot * 0.0305;
            resSum6.Text = resFoot.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(rate7.Text);
            double resMile = rateMile * 1609.34;
            resSum7.Text = resMile.ToString();
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rate8.Text);
            double resVerst = rateVerst * 1066.8;
            resSum8.Text = resVerst.ToString();
        }




    }
}
