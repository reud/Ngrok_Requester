Ngrok Requester
====


大学の授業の自由課題で作成した、ngrokのURLにGETリクエストをほんのちょこっとだけ簡単に送れるアプリケーション


## Description
ngrokのURLにGETリクエストにワンクリックでGETリクエストを送ります([文字列].ngrok.io/のみ)

※ver 1.1 からシリアルポートを監視してデータが来たら、GETリクエストを送れるようになりました。

## Demo
![demo画像](https://github.com/reud/Ngrok_Requester/blob/master/Requester/demo.PNG?raw=true "Demo")

## Requirement
.NET Framework ・・・多分
## Usage
中央にあるテキストボックスに生成された文字列を入力してボタンを押すだけ！(CTRL+Sでも可)
出力結果はボタンの下に出力されます。

※シリアルポートからデータが来たらリクエストを送るようにしたい場合、右上から該当ポートを選択してください。

シリアルポートにデータを送る際、Arduino UNOで送る時のサンプルコードを書きました。
サンプルコードはここ

## Licence

This software is released under the MIT License, see below.

Copyright 2018 reud

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Author
[reud](https://github.com/reud)
