# 變數定義
BINARY_NAME=LeetCode
MAIN_FILE=main.go

# 預設目標
.PHONY: all
all: build

# 編譯程式
.PHONY: build
build:
	go build -o $(BINARY_NAME).exe .

# 執行程式
.PHONY: run
run:
	go run $(MAIN_FILE)

# 執行測試
.PHONY: test
test:
	go test ./...

# 清理編譯檔案
.PHONY: clean
clean:
	del $(BINARY_NAME).exe 2>nul || true

# 格式化程式碼
.PHONY: fmt
fmt:
	go fmt ./...

# 檢查程式碼
.PHONY: vet
vet:
	go vet ./...

# 下載依賴
.PHONY: deps
deps:
	go mod download
	go mod tidy

# 為不同平台編譯
.PHONY: build-all
build-all:
	@echo "編譯 Windows 版本..."
	set GOOS=windows&& set GOARCH=amd64&& go build -o $(BINARY_NAME)-windows.exe $(MAIN_FILE)
	@echo "編譯 Linux 版本..."
	set GOOS=linux&& set GOARCH=amd64&& go build -o $(BINARY_NAME)-linux $(MAIN_FILE)
	@echo "編譯 macOS 版本..."
	set GOOS=darwin&& set GOARCH=amd64&& go build -o $(BINARY_NAME)-macos $(MAIN_FILE)

# 顯示說明
.PHONY: help
help:
	@echo "可用的 make 命令："
	@echo "  build      - 編譯程式"
	@echo "  run        - 執行程式"
	@echo "  test       - 執行測試"
	@echo "  clean      - 清理編譯檔案"
	@echo "  fmt        - 格式化程式碼"
	@echo "  vet        - 檢查程式碼"
	@echo "  deps       - 下載並整理依賴"
	@echo "  build-all  - 為多平台編譯"
	@echo "  help       - 顯示此說明"
