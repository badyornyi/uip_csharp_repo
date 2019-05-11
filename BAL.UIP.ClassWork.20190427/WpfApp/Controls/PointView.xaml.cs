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

namespace WpfApp.Controls
{
    /// <summary>
    /// Interaction logic for PointView.xaml
    /// </summary>
    public partial class PointView : UserControl
    {
        public PointView()
        {
            InitializeComponent();
        }

        internal Point GetPoint()
        {
            int XCoord = Convert.ToInt32(this.X.Text);
            int YCoord = Convert.ToInt32(this.Y.Text);
            return new Point(XCoord, YCoord);
        }
    }
}
