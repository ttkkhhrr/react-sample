# 開発環境の設定
IDEはvscodeを想定。

### コンテナを使用する場合
**①vscodeの設定**  
vscode右側メニューのExtensions(四角形が４つのアイコン)から、「Remote Development」をインストール

**②プロキシの設定**  
「.devcontainer/devcontainer.json」のプロキシ情報とコメントされている箇所を必要に応じて修正。(プロキシ無しの場合は空文字にする。)

**③vscodeにてフォルダを開く**  
vscodeにてフォルダを開く

**④開発コンテナの起動**  
右下の通知から「Reopen in Container」を選択。  
もしくは、左下の「><」マークから「Remote-Containers: Reopen in Container」を選択。

初回起動時は20分ほど時間が掛かります。(主にreact関連のライブラリのインストールで。)

### コンテナを使用しない場合
**①vscodeの設定**  
vscode右側メニューのExtensions(四角形が４つのアイコン)から、以下をインストール  
・C#  
・Git History  
  


**②SDK等のインストール**  
以下をインストール  
**node.js12.18**  
https://nodejs.org/ja/

**.NET Core SDK3.1**  
https://dotnet.microsoft.com/download

# DBコンテナの起動方法
「ServerApp/DB_Docker/start.bat」の実行で起動。  
同フォルダの「stop.bat」の実行で停止。  
(共にホスト側で実行してください。ホストから見ると、開発環境のコンテナとDBコンテナの２つが起動した状態になります。)  


# デバッグ方法

### C#側のデバッグ開始
左側メニューのRun(虫のアイコン)をクリック → 上部のセレクトリストで「.NET Core Launch(Web)」が選択されていることを確認し、リスト左の実行アイコンをクリック。

### React側のデバッグ開始
**Linux（コンテナ内）の場合**  
画面上部の「Terminal」→「Run Task..」→「linux-webpack-devserver」を選択

**Windowsの場合**  
画面上部の「Terminal」→「Run Task..」→「win-webpack-devserver」を選択

両方を起動後、ホスト側のブラウザで「http://localhost:5001」にアクセスするとログインページが表示されます。  
ID・パスワードは以下になります。  
user1  
password  





