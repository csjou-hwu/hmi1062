package main

import (
    "io"
    "net/http"
)

// 處理 request 和 response 的函式
func hello(w http.ResponseWriter, r *http.Request) {
    // 印出 hello world
    io.WriteString(w, "Hello 周重石 09907 ! ")
}
func hellohwu(w http.ResponseWriter, r *http.Request) {
    // 印出 hello world
    io.WriteString(w, "Hello 周重石 hwu ! ")
}

func main() {
    // router 讓網址可以對應處理函式
    http.HandleFunc("/099007", hello)
    http.HandleFunc("/hwu", hellohwu)
    // 監聽 8000 port
    http.ListenAndServe(":8000", nil)
}