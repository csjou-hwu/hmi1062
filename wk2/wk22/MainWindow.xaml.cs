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

namespace wk22
{
    using System.Windows.Media.Media3D;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double 角度 = 0;
        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                Point3D 位置 = new Point3D();
                位置 = 相機.Position;
                //位置.X += 1;
                角度 += 1.0;
                位置.X = 10 * Math.Sin(角度 / 180.0 * Math.PI);
                位置.Z = 10 * Math.Cos(角度 / 180.0 * Math.PI);
                相機.Position = 位置;
                相機.LookDirection = new Vector3D(-位置.X, 0, -位置.Z);
            }
            else
            {
                Point3D 位置 = new Point3D();
                位置 = 相機.Position;
                //位置.X += 1;
                角度 -= 1.0;
                位置.X = 10 * Math.Sin(角度 / 180.0 * Math.PI);
                位置.Z = 10 * Math.Cos(角度 / 180.0 * Math.PI);
                相機.Position = 位置;
                相機.LookDirection = new Vector3D(-位置.X, 0, -位置.Z);
            }
        }
    }
}
