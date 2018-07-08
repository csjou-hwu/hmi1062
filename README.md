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

## Wk10 git and gitea
### 10-1 git 基本語法
### 10-2 git 專案建置
建置github帳號 <br/>
登入 <br/>
建置專案 <br/>
本地端安裝github <br/>
下載專案 git clone https://github.com/csjou-hwu/xxxx <br/>
上傳檔案至已存在的儲存庫 <br/>
新增 -> git add . <br/>
附註 -> git commit -m "附註" <br/>
上傳 -> git push -u origin master <br/>
查看本地端檔案是否更改 <br/>
### 10-3  gitea
10-3- 1 在本機安裝 Gitea ，登入Gitea 截圖 <br/>
10-3-1 下載 git (https://git-scm.com/downloads) <br/>
10-3-2  安裝 git <br/>
10-3-3 下載 gitea gitea-1.4.0-windows-4.0-386.exe (https://github.com/go-gitea/gitea/releases) <br/>
10-3-4  執行 gitea gitea-1.4.0-windows-4.0-386.exe <br/>
A - MySQL <br/>
10-3-5 mySQL (下載MySQL 免安裝版)<br/>
10-3-6 建立 gitea 資料庫 <br/>
A - MySQL <br/>
10-3-5 mySQL (下載MySQL 免安裝版) <br/>
10-3-6 建立 gitea 資料庫 <br/>
10-3-7 MySQL 先有 gitea Database <br/>
管理員帳號<br/>
10-3-8  建立使用者(註冊)<br/>
B--- SQLite3 <br/>
10-3-5B  sqlite3 (選擇 sqlite3) <br/>
10-3-6B administrator 設定 <br/>
10-3-7B  建立gitea  <br/>

### 10-4 在Gitea 新建專案，建立README.md 修改內容包括姓名學號上傳後在Gitea 介面截圖
#### 10-4-1 建立wk10
#### 10-4-3
10-4-4 安裝git 啟用 gitcmd <br/>
md wk10 <br/>
cd wk10 <br/>
echo “Readme file” >> README.md <br/>
git init <br/>
git add README.md <br/>
git commit -m "first commit" <br/>
git remote add origin http://localhost:3000/csjou/wk10.git <br/>
git push -u origin master <br/>
### 10-4-5 重新載入http://localhost:3000/csjou/wk10

## wk11 golang 簡介、安裝 	 
### 11-3 使用Go在Command Line 視窗打印出Helloworld + 你的學號 截圖
### 11-3-1 Download go https://golang.org/dl/
https://gobyexample.com/hello-world <br/>
### 11-3-2 helloworld.go
import "fmt" <br/>
func main() { <br/>
    fmt.Println("hello world") <br/>
} <br/>
### 11-3-3 Test basic syntax 
### 11-4 Say Hello http server
https://hackernoon.com/how-to-create-a-web-server-in-go-a064277287c9 <br/>

## 12-1 處理 request 和 response 的函式
package main <br/>
import ( <br/>
	"io" <br/>
	"net/http" <br/>
)<br/>
// 處理 request 和 response 的函式 <br/>
func hello(w http.ResponseWriter, r *http.Request) { <br/>
	// 印出 hello world <br/>
	io.WriteString(w, "Hello world!") <br/>
}<br/>
func main() { <br/>
	// router 讓網址可以對應處理函式 <br/>
	http.HandleFunc("/", hello) <br/>
	// 監聽 8000 port <br/>
	http.ListenAndServe(":8000", nil) <br/>
}<br/>

### 12-2 http rountings
### 12-3.go Parameters

## Wk13 golang(二)實務應用 
### 13-0 GUI 案例展示(使用本機網頁伺服器，運用網頁圖形介面製作app)
download uniSimpleConsole.exe <br/>

### 13-1 簡易網站程式(public目錄放置html files)
13-1-1 13-1.go <br/>
13-1-2 Testing files <br/>
13-1.go <br/>
index.html @public  <br/>
011.jpg @public/images <br/>
go run 13-1.go <br/>
chrome http://localhost:8000/index.html <br/>
#### 13-2 分頁 <br/>
#### 13-3 資料編輯(以字串陣列變數儲存於Server 程式)
13-3-1 Files <br/>
13-3.go <br/>
index.html @ templates ... <br/>
go run 13-3.go <br/>

## Wk14 golang(三)案例分析
### 14-1.go package 應用 (go test 指令)
14-1-1 download 14-1.go <br/>
4-1-2 go get : github.com/hwu-jason/goPackageTest <br/>
14-1-3 ctrl+B (How are you ,HWU) <br/>
14-1-4 cmd <br/>
14-1-5 git clone https://github.com/hwu-jason/goPackageTest <br/>
14-1-6 cd  C:\Users\Use\go\src\github.com\hwu-jason\goPackageTest <br/>
14-1-7 go test <br/>
### 14-2 sqlite database 整合應用
14-2-1 download 12-d1.go <br/>
14-2-2 Download and install  gcc (https://sourceforge.net/projects/tdm-gcc/) <br/>
14-2-3 go run 12-d1.go <br/>

### 14-2-4 Download Database Browser for sqlite
https://sqlitebrowser.org/ <br/>
14-2-5 Add data <br/>
_, err = db.Exec("insert into foo(id, name) values(111, 'foo'), (112, 'bar'), (113, 'baz')") <br/>
	if err != nil { <br/>
		log.Fatal(err) <br/>
	} <br/>
	for i := 1001; i < 1100; i++ { <br/>
		_, err = db.Exec(fmt.Sprintf("insert into foo(id, name) values( %d , '%s')", i, fmt.Sprintf("hwu世界%04d", i))) <br/>
		if err != nil { <br/>
			log.Fatal(err)<br/>
		}<br/>
	}<br/>
 
## Wk15 Git/Visual Studio Code/golang整合運用
Aframe + golang 整合簡介	<br/>
### 15-1 go 網站 (13-1.go)
### 15-2 a-frame.io webvr 網頁
### 15-3 嵌入式本機網頁(web ui 應用)
go build -o main.exe 13-1.go <br/>
start main.exe (background running) <br/>
"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"  --app=http://localhost:8000/aframe.html <br/>
### 15-4 封裝嵌入式網頁
準備 main.exe (13-1.go) + public 目錄 <br/>
go run zip.go <br/>
 2-1 zip main.exe + public folder ⇒ hwu <br/>
 2-2 7zr.exe a hwu.7z hwu install.exe (zip hwu + install.exe into hwu.7z) <br/>
	2-3 copy /b 7zS.sfx + config.txt + hwu.7z hwu.exe <br/>
----> 產生hwu.exe 移至桌面<br/>
安裝hwu.exe 產生 startlink 桌面 ( localhost  @ "c:\\GoProject\\src\\hwu\\") <br/>
點選桌面link 啟動 <br/>

## Wk16 aframe
### 16-1 a-frame 3D basic concept
### 16-2 a-frame 360 image
### 16-3 a-frame 3D model

## Wk17 Web AR 入門
https://aframe.io/blog/arjs/ <br/> 
https will be requireed. <br/>
### 17 a-frame
#### 17-1 asp.net core sdk 建置網站
#### 17-2 a-frame 3D basic concept
https://aframe.io/docs/0.8.0/introduction/ <br/>
### 17-3 a-frame 360 image
https://github.com/aframevr/aframe/blob/v0.7.0/examples/boilerplate/panorama/index.html <br/>
https://aframe.io/docs/0.8.0/primitives/a-sky.html <br/>
### 17-4 a-frame 3D model
https://github.com/aframevr/aframe/tree/master/examples/showcase/shopping <br/>
### 17-5 go 建置網站 13-1.go
Download go https://golang.org/dl/ <br/>

## Wk18 WebVR 整合測試
1 以aframe.io網頁範例程式為例(https://aframe.io/docs/0.8.0/introduction/)，將所有物件調整成紅(red, #FF0000)，綠(green, #00FF00)與藍(blue, #0000FF)，並分別以手機與電腦測試。<br/>
2. 以第1題為基礎，將第2題天空變更圖片為(https://classroom.google.com/u/0/c/MTE2Mjk2Nzk0MDFa)，並分別以手機與電腦測試。<br/>
3. 以第2題為基礎，下載男模3D模型(man.dae, man-color.jpg)，並分別以手機與電腦測試。<br/>
https://github.com/aframevr/aframe/tree/master/examples/showcase/shopping<br/>
4. 請參考13-1.go 建置網站 ，將1-3題，網頁程式，分別以手機與電腦測試。<br/>
5. 參考wk15-4 嵌入式本機網頁(web ui 應用)以第三題為例<br/>
go build -o main.exe 13-1.go<br/>
start main.exe (background running)<br/>
"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"  --app=http://localhost:8000/aframe.html <br/>
