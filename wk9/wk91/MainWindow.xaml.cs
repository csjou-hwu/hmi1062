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

namespace wk912
{
    using Microsoft.Kinect;
            //<h:HelixViewport3D.Camera>
            //    <PerspectiveCamera Position = "0 1 -10" LookDirection="0 0 1" UpDirection="0 1 0" />
            //</h:HelixViewport3D.Camera>
            //<h:DefaultLights/>
            //<h:FileModelVisual3D Source = "C:\Users\User\Downloads\models\bar.obj" />
            //------------------
            //<PerspectiveCamera Position = "7 1 -20" LookDirection="0 0 1" UpDirection="0 1 0" />
            //</h:HelixViewport3D.Camera>
            //<h:DefaultLights/>
            //<h:FileModelVisual3D Source = "C:\Users\User\Downloads\models\tables.obj" />
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KinectSensor 感測器 = KinectSensor.KinectSensors[0];
            感測器.AudioSource.SoundSourceAngleChanged += AudioSource_SoundSourceAngleChanged; //+= AudioSource_BeamAngleChanged;
            感測器.Start();
            感測器.AudioSource.Start();
        }

        private void AudioSource_SoundSourceAngleChanged(object sender, SoundSourceAngleChangedEventArgs e)
        {
            this.Title = e.Angle.ToString();
            if (e.Angle < 0)
            {
                //Position = "0 1 -10"
                模型.Source = @"C:\Users\User\Downloads\models\bar.obj";
                相機.Position = new System.Windows.Media.Media3D.Point3D(0, 1, -10);
                
            }
            else
            {
                //Position = "0 1 -10"
                模型.Source = @"C:\Users\User\Downloads\models\tables.obj";
                相機.Position = new System.Windows.Media.Media3D.Point3D(7, 1, -20);
                
            }
        }

        private void AudioSource_BeamAngleChanged(object sender, BeamAngleChangedEventArgs e)
        {
            
        }
    }
}
