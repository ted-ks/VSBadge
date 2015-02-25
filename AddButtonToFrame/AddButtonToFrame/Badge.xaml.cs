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
using Microsoft.VisualStudio.PlatformUI.Shell.Controls;

namespace Company.AddButtonToFrame
{
    /// <summary>
    /// Interaction logic for Badge.xaml
    /// </summary>
    public partial class Badge : UserControl, INonClientArea
    {
        public Badge()
        {
            InitializeComponent();
        }

        private void BadgeFlagButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!!!", "Badge", MessageBoxButton.OK);
        }

        public int HitTest(Point point)
        {
            return 1;
        }
    }


}
