# hmi1062
1. 硬體： 1. PC @ Windows 7 2. Kinect 1.0  3. Mobile (Android or iphone) <br/>
2. 軟體： 1. Visual Studio 2017, 2. Kinect SDK 1.8, 3. go (Webapp) 4. a aframe (webVR)<br/>
## Update procedure
1. cmd <br/>
2. cd path <br/>
3. git clone https://csjou-hwu/hmi1062 <br/>
4. cd hmi1062 <br/>
5. copy folders into hmi1062 <br/>
6. git add . <br/>
7. git commit -m "Update files" <br/>
8. git push origin <br/>
9. input user name (email) and password <br/>
# Outline
## Wk2 Course Brief / C# review 3-layers/4 apps + Visual Studio 2017 	 
### 2-2. WPF 3D 複習。 Scene + Camera
https://docs.microsoft.com/zh-tw/dotnet/framework/wpf/graphics-multimedia/3-d-graphics-overview
### 2-3 MouseWheel + RotateTransform

## Wk3 WPF 3D Animation (xaml Okino https://www.okino.com/conv/exp_xaml2.htm) 
### 3-1 座標轉換運用
### 3-1-1 平面影片，物件旋轉動畫(X-axis, Y-Axis)
### 3-1-2 平面物件旋轉六面體 https://docs.microsoft.com/zh-tw/dotnet/framework/wpf/graphics-multimedia/3-d-graphics-overview
http://csjoublog.blogspot.tw/2018/03/blog-post.html
### 3-1平面影片
### 3-2 Kinect Audio Control (Simple version)
3-2. Kinect 入門範例。 
https://www.microsoft.com/en-us/download/details.aspx?id=40278 <br/>
3-2-1 Audio Basic-WPF <br/>
this.sensor.AudioSource.BeamAngleChanged += this.AudioSourceBeamChanged;
this.sensor.AudioSource.SoundSourceAngleChanged += this.AudioSourceSoundSourceAngleChanged;
// Start streaming audio!
this.audioStream = this.sensor.AudioSource.Start();
3-2-2 Console mode 簡化聲音輸入測試
1. download
https://drive.google.com/file/d/0BwOA9PgOV_oxSzV4V2ZvVnNmdDQ/view
2. Unzip copy to C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\PublicAssemblies
3. 開啟 vs2017 cmd
3. cd C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\PublicAssemblies
4. gacutil -i Microsoft.VisualStudio.Shell.Interop.11.0.dll


Wk4 Kinect Gesture Brief 	
4-1 Controls Basic-WPF
4-1-1 Demo
4-1-2 KinectTileButton



4-2 Helixtoolkit
https://github.com/helix-toolkit
https://archive.codeplex.com/?p=helixtoolkit
X Install-Package HelixToolkit.Wpf -Version 1.1.0 i302 target to framework 4.0 can not be accepted.
Use nuget browser

4-2-1 Teapod
4-2-3 Key.Up event 

Wk5 Kinect Gesture Application
5-1 Controls Basic-WPF(簡化應用)
http://csjoublog.blogspot.tw/2018/03/kinecttilebutton.html





5-2 點餐



5-3 WPF 3D Animation (xaml Okino https://www.okino.com/conv/exp_xaml2.htm)
Wk6 放假
Wk7 Helixtoolkit 3D + 2D object (Kinect)
7-1 WPF 3D Animation (xaml Okino https://www.okino.com/conv/exp_xaml2.htm)


7-2 (4-2) Helixtoolkit
4-2 Helixtoolkit
https://github.com/helix-toolkit
https://archive.codeplex.com/?p=helixtoolkit
X Install-Package HelixToolkit.Wpf -Version 1.1.0 i302 target to framework 4.0 can not be accepted.
Use nuget browser



7-3 Kinect Controls Basics-WPF



7-4 整合 xaml 3D + Helixtoolkit 3D + Kinect gesture control
