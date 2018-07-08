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
        int 購物車 = 0;
        private readonly KinectSensorChooser sensorChooser;
        public MainWindow()
        {
            InitializeComponent();
            // KinectTileButton Loop
            //              < k:KinectTileButton Label = "1" >
            //                   < k:KinectTileButton.Background >
            //                      < ImageBrush ImageSource = "C:\Users\User\source\repos\wk5\wk51\m1.png" />
            //                   </ k:KinectTileButton.Background >
            //                </ k:KinectTileButton >
            int[] 價錢 = { 99, 109, 129, 79, 139, 99, 109, 129, 79, 139};
            for (int i = 0; i < 10; i++)
            {
                KinectTileButton 菜單 = new KinectTileButton();
                菜單.Tag = 價錢[i].ToString();
                菜單.Label = (i + 1).ToString();
                ImageBrush 背景 = new ImageBrush();
                背景.ImageSource = new BitmapImage(new Uri(@"C:\Users\User\source\repos\wk5\wk51\m" + (i + 1).ToString() + ".png"));
                菜單.Background = 背景;
                wrapPanel.Children.Add(菜單);
            }
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
            //按鈕.Label = "按過了";
            購物車 += int.Parse(按鈕.Tag.ToString());
            this.Title = "目前共點餐 : " + 購物車.ToString() + " 元";
        }
    }
}
