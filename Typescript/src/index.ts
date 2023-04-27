// {
//    "根基": {
//      "scope": "javascript,typescript,typescriptreact,javascriptreact,csharp",
//      "prefix": "-BASE",
//      "body": [
//        "// 你現在是一個程式碼專家，請你觀察接下來的程式碼內部的註解",
//        "// 找出各種以chatGPT任務開始開頭的任務",
//        "// 請你滿足其需求，並回復CodeBlock(```)包覆的程式碼",
//        "// 每個任務都有作用範圍",
//        "// 若搜索不到任何chatGPT任務則直接返回一段文字 找不到任務"
//      ]
//    },
//    "修改": {
//      "scope": "javascript,typescript,typescriptreact,javascriptreact,csharp",
//      "prefix": "-ADJUST",
//      "body": ["// chatGPT任務開始: 幫我調整功能:請你$1"]
//    },
//    "檢查": {
//      "scope": "javascript,typescript,typescriptreact,javascriptreact,csharp",
//      "prefix": "-REVIEW",
//      "body": ["// chatGPT任務開始: 幫我檢查以下程式碼", "// 看看是否能優化、是否符合該語言的最佳實踐、是否有安全漏洞、性能瓶頸、無用的程式碼、冗贅的語法"]
//    },
//    "轉換": {
//      "scope": "javascript,typescript,typescriptreact,javascriptreact,csharp",
//      "prefix": "-CONVERT",
//      "body": ["// chatGPT任務開始: 幫我將以下程式碼轉成 $1語言"]
//    },
//    "教我": {
//      "scope": "javascript,typescript,typescriptreact,javascriptreact,csharp",
//      "prefix": "-TEACH",
//      "body": ["// chatGPT任務開始: 以下程式碼我看不懂，請你將程式碼分成幾個CodeBlock(```)後 用註解to解釋每個部份的作用"]
//    },
//    "註解": {
//      "scope": "javascript,typescript,typescriptreact,javascriptreact,csharp",
//      "prefix": "-COMMENT",
//      "body": ["// chatGPT任務開始: 替以下程式碼寫註解用星字號包覆"]
//    },
//    "停下": {
//      "scope": "javascript,typescript,typescriptreact,javascriptreact,csharp",
//      "prefix": "-ENDS",
//      "body": ["// chatGPT任務作用域結束"]
//    }
//  }
 