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

namespace wk31
{
    using Microsoft.Kinect;
    //1. add ref
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KinectSensor 感測物件 = KinectSensor.KinectSensors[0];
            感測物件.AudioSource.BeamAngleChanged += AudioSource_BeamAngleChanged;
            感測物件.Start();
            感測物件.AudioSource.Start();
        }

        private void AudioSource_BeamAngleChanged(object sender, BeamAngleChangedEventArgs e)
        {
            //旋轉.Angle = e.Angle;
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
                旋轉.Angle += 10;
            else
                旋轉.Angle -= 10;
        }
    }
}
