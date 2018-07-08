using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk911
{
    using Microsoft.Kinect;
    class Program
    {
        static void Main(string[] args)
        {
            KinectSensor 感測器 = KinectSensor.KinectSensors[0];
            感測器.AudioSource.BeamAngleChanged += AudioSource_BeamAngleChanged;
            感測器.Start();
            感測器.AudioSource.Start();
            Console.WriteLine("Enter to Stop");
            Console.ReadLine();
        }

        private static void AudioSource_BeamAngleChanged(object sender, BeamAngleChangedEventArgs e)
        {
            Console.WriteLine(e.Angle.ToString());
        }
    }
}
