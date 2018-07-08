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

namespace wk46
{
    using Microsoft.Kinect;
    using Microsoft.Kinect.Toolkit;
    using Microsoft.Kinect.Toolkit.Controls;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KinectSensor s = KinectSensor.KinectSensors[0];
            var regionSensorBinding = new Binding("Kinect") { Source = s };
            BindingOperations.SetBinding(this.kinectRegion, KinectRegion.KinectSensorProperty, regionSensorBinding);
            try
            {
                s.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                s.SkeletonStream.Enable();

                try
                {
                    s.DepthStream.Range = DepthRange.Near;
                    s.SkeletonStream.EnableTrackingInNearRange = true;
                }
                catch (InvalidOperationException)
                {
                    // Non Kinect for Windows devices do not support Near mode, so reset back to default mode.
                    s.DepthStream.Range = DepthRange.Default;
                    s.SkeletonStream.EnableTrackingInNearRange = false;
                }
            }
            catch (InvalidOperationException)
            {
                // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                // E.g.: sensor might be abruptly unplugged.
            }
            s.Start();

        }

        private void wrapPanel_Click(object sender, RoutedEventArgs e)
        {

        }
        private void KinectTileButtonClick(object sender, RoutedEventArgs e)
        {
            this.Title = ((KinectTileButton)sender).Label.ToString();
        }
    }
}
