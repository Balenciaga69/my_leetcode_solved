package main

import (
	"os"
	"os/exec"
)

func main() {
	// 執行所有測試
	cmd := exec.Command("go", "test", "./solved/...")
	cmd.Stdout = os.Stdout
	cmd.Stderr = os.Stderr
	if err := cmd.Run(); err != nil {
		panic(err)
	}
}
