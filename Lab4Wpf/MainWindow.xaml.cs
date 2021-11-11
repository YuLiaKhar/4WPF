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

namespace Lab4Wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resEuro = rateEuro * sumEuro;
            resSumE.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rateG.Text);
            double sumGriv = Convert.ToDouble(sumG.Text);
            double resGriv = rateGriv * sumGriv;
            resSumG.Text = resGriv.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateArmD = Convert.ToDouble(rateA.Text);
            double sumArmD = Convert.ToDouble(sumA.Text);
            double resArmD = rateArmD * sumArmD;
            resSumA.Text = resArmD.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double duim = Convert.ToDouble(numD.Text);
            double metrD = Math.Round(duim / 39.37, 2);
            resD.Text = metrD.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double fut = Convert.ToDouble(numF.Text);
            double metrF = Math.Round(fut / 3.28, 2);
            resF.Text = metrF.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mile = Convert.ToDouble(numM.Text);
            double metrM = Math.Round(mile * 1609.34, 2);
            resM.Text = metrM.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double versta = Convert.ToDouble(numV.Text);
            double metrV = Math.Round(versta * 1066.8, 2);
            resV.Text = metrV.ToString();
        }
    }
}
