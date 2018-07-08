package main

import (
	"fmt"
	"net/http"

	"github.com/gorilla/mux"
)

func main() {
	r := mux.NewRouter()
	r.HandleFunc("/{books}/{title}/{page}", func(w http.ResponseWriter, r *http.Request) {
		vars := mux.Vars(r)
		title := vars["title"]
		page := vars["page"]
		books := vars["books"]
		fmt.Fprintf(w, "You've requested the %s : %s on page %s\n", books, title, page)
	})

	http.ListenAndServe(":8000", r)
}
