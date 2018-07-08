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
this.sensor.AudioSource.BeamAngleChanged += this.AudioSourceBeamChanged;  <br/>
this.sensor.AudioSource.SoundSourceAngleChanged += this.AudioSourceSoundSourceAngleChanged; <br/>
// Start streaming audio! <br/>
this.audioStream = this.sensor.AudioSource.Start(); <br/>
### 3-2-2 Console mode 簡化聲音輸入測試
#### 修補手動加入參考界面<br/>
1. download <br/>
https://drive.google.com/file/d/0BwOA9PgOV_oxSzV4V2ZvVnNmdDQ/view <br/>
2. Unzip copy to C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\PublicAssemblies <br/>
3. 開啟 vs2017 cmd <br/>
3. cd C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\PublicAssemblies <br/>
4. gacutil -i Microsoft.VisualStudio.Shell.Interop.11.0.dll <br/>

## Wk4 Kinect Gesture Brief 	
### 4-1 Controls Basic-WPF
### 4-1-1 Demo
### 4-1-2 KinectTileButton

### 4-2 Helixtoolkit
https://github.com/helix-toolkit <br/>
https://archive.codeplex.com/?p=helixtoolkit <br/>
X Install-Package HelixToolkit.Wpf -Version 1.1.0 i302 target to framework 4.0 can not be accepted. <br/>
#### Use nuget browser
### 4-2-1 Teapod
### 4-2-3 Key.Up event 

## Wk5 Kinect Gesture Application
### 5-1 Controls Basic-WPF(簡化應用)
http://csjoublog.blogspot.tw/2018/03/kinecttilebutton.html <br/>

### 5-2 手勢點餐

### 5-3 WPF 3D Animation (xaml Okino https://www.okino.com/conv/exp_xaml2.htm)
## Wk6 Off
## Wk7 Helixtoolkit 3D + 2D object (Kinect)
### 7-1 WPF 3D Animation (xaml Okino https://www.okino.com/conv/exp_xaml2.htm)
### 7-2 (4-2) Helixtoolkit
### 4-2 Helixtoolkit
Use nuget browser <br/>
### 7-3 Kinect Controls Basics-WPF
### 7-4 整合 xaml 3D + Helixtoolkit 3D + Kinect gesture control
 
## wk8 擴增實境(紙片人 in 3D Enviroment)
### 8-1 Kinect background removal demo
#### 8-1-1 Demo sample
#### 8-1-2 MouseWheel 事件，改變背景圖片
### 8-2 Kinect background remove + Helixtoolkit

### 8-3 HTML (aspnet core sdk)
#### 8-3-1 Webserver
1. VS2017 CMD <br/>
2. dotnet --version <br/>
3. dotnet new web -o wk83 <br/>
4. cd wk83<br/>
5. dotnet run<br/>
#### 8-3-2 Razor template (C# Available)
1. VS 2017 cmd <br/>
2. md wk84 <br/>
3. cd wk84 <br/>
4. dotnet new razor -o wk841 <br/>
5. cd wk841 <br/>
6. Program.cs <br/>
 .UseUrls("http://192.168.225.170:5050") <br/>
7. dotnet run  <br/>

#### 8-3-2 a-frame.io

## wk9 整合測驗
### 9-1 請用整合聲音控制[Kinect Audio Control (簡化版)]與Helixtoolkit 3D模型，用聲音方位改變事件，切換左右餐廳(bar.obj/tables.obj)展示。
### 9-2 請用參考手勢控制(Kinect Controls Basics -WPF)範例，建立必勝客點餐系統(自行選取5個披薩為例)。
### 9-3 請用整合人像去背(Kinect Background removal)與Helixtoolkit 3D模型(newsdesk2.obj)，建立新聞播報應用程式。
### 9-4 請使用VS2017建立網站，參考https://aframe.io/docs/0.8.0/primitives/a-obj-model.html，建立tables.obj虛擬實境網頁。
### 9-5 請使用ASP.NET Core SDK建立網站，參考https://aframe.io/docs/0.8.0/primitives/a-obj-model.html，建立tables.obj虛擬實境網頁，以個人手機測試此網頁


