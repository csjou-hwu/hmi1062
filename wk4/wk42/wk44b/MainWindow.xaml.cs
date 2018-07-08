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

namespace wk44b
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //if (e.Delta > 0)
            //    Ro.Angle += 5;
            //else
            //    Ro.Angle -= 5;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
                Ro.Angle += 5;
            if (e.Key == Key.Left)
                Ro.Angle -= 5;
        }
    }
}
