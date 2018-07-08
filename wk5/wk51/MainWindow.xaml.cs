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

namespace wk51
{
    using Microsoft.Kinect;
    using Microsoft.Kinect.Toolkit;
    using Microsoft.Kinect.Toolkit.Controls;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly KinectSensorChooser sensorChooser;
        public MainWindow()
        {
            InitializeComponent();
            // initialize the sensor chooser and UI
            this.sensorChooser = new KinectSensorChooser();
            //this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            //args.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
            //args.NewSensor.SkeletonStream.Enable();
            KinectSensor.KinectSensors[0].DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
            KinectSensor.KinectSensors[0].SkeletonStream.Enable();
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start();

            // Bind the sensor chooser's current sensor to the KinectRegion
            var regionSensorBinding = new Binding("Kinect") { Source = this.sensorChooser };
            BindingOperations.SetBinding(this.kinectRegion, KinectRegion.KinectSensorProperty, regionSensorBinding);

        }

        private void wrapPanel_Click(object sender, RoutedEventArgs e)
        {
            KinectTileButton 按鈕 = (KinectTileButton)e.OriginalSource;
            按鈕.Label = "按過了";
        }
    }
}
