using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Point> points = new List<Point> {
                this.P1.GetPoint(),
                this.P2.GetPoint(),
                this.P3.GetPoint(),
            };

            MessageBox.Show($"Calculated result = {CalculateEarthSquare(points)}");
            
        }

        private double CalculateEarthSquare(List<Point> points, bool isAlternativeCalculation = false)
        {
            double landArea = 0;

            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i == points.Count - 1) ? 0 : i + 1;
                int prevIndex = (i == 0) ? points.Count - 1 : i - 1;

                double par1 = isAlternativeCalculation ? points[i].X : points[i].Y;
                double par2_1 = isAlternativeCalculation ? points[nextIndex].Y : points[prevIndex].X;
                double par2_2 = isAlternativeCalculation ? points[prevIndex].Y : points[nextIndex].X;

                double tempLandArea = landArea;
                landArea += par1 * (par2_1 - par2_2);
            }
            double result = (double)Math.Abs(landArea / 2);

            //Logger.Info($"[{this.GetType().Name}]:" + (isAlternativeCalculation ? "Alternative" : "") + "Result Calculation = " + result);

            return result;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string textToPrint = 
        //        $"Name = {this.UserName_TextBox.Text}\n" +
        //        $"Address = {this.Address_TextBox.Text}\n" +
        //        $"Password = {this.Password_PasswordBox.Password}";

        //    Debug.WriteLine(textToPrint);
        //    MessageBox.Show(textToPrint);
        //}

    }
}
