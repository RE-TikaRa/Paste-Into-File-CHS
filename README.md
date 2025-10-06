# PasteIntoFile

一键将剪贴板内容保存为文件的 Windows 工具 | Quickly save clipboard content to files on Windows


<br />

<p align="center">
  <a href="https://github.com/EslaMx7/PasteIntoFile/">
    <img src="PasteIntoFile/icon.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">PasteIntoFile</h3>
  <p align="center">
    简单、快速、高效的剪贴板文件保存工具
    <br />
    <a href="https://github.com/EslaMx7/PasteIntoFile"><strong>探索本项目的文档 »</strong></a>
    <br />
    <br />
    <a href="https://github.com/EslaMx7/PasteIntoFile/releases">下载最新版本</a>
    ·
    <a href="https://github.com/EslaMx7/PasteIntoFile/issues">报告Bug</a>
    ·
    <a href="https://github.com/EslaMx7/PasteIntoFile/issues">提出新特性</a>
  </p>


## 📖 目录

[TOC]

---

## 源项目
**作者**：EslaMx7
**仓库**：https://github.com/EslaMx7/PasteIntoFile

## 项目简介

**PasteIntoFile** 是一个轻量级的 Windows 桌面工具,让你能够快速将剪贴板中的内容(文本、图片等)保存为文件,无需打开记事本或画图工具。本项目仅作汉化处理。

### 为什么选择 PasteIntoFile?

- 🚀 **快速保存** - 一键将剪贴板内容保存为文件
- 🌍 **多语言支持** - 自动检测系统语言,支持中文和英文界面
- ⚙️ **高度可定制** - 自定义文件名格式,支持日期时间变量
- 🖱️ **右键菜单集成** - 在任意文件夹空白处右键快速调用
- 💾 **轻量无依赖** - 仅 181KB,无需安装额外运行时
- 🎨 **现代化界面** - 简洁美观的 Windows Forms 界面

---

## 功能特性

### ✨ 核心功能

- [x] 支持保存**文本内容**到 TXT 文件
- [x] 支持保存**图片内容**到 PNG 文件
- [x] 自定义**文件名格式**(支持日期时间变量)
- [x] **实时预览**文件名效果
- [x] **右键菜单集成** - 在文件夹中快速调用

### 🌐 多语言支持

- [x] **中文界面** (简体中文)
- [x] **英文界面** (English)
- [x] **自动检测**系统语言
- [x] **实时切换**语言无需重启
- [x] 语言设置持久化保存

### 🛠️ 高级功能

- [x] 命令行参数支持
- [x] 注册表配置管理
- [x] Windows 资源管理器右键菜单注册
- [x] 文件名格式变量系统 (`{datetime}`, `{date}`, `{time}`, `{timestamp}`)

---

## 快速开始

### 系统要求

- **操作系统**: Windows 7 / 8 / 10 / 11
- **.NET Framework**: 4.7.2 或更高版本
- **架构**: x86 / x64

### 安装步骤

1. **下载最新版本**
   
   前往 [Releases](https://github.com/EslaMx7/PasteIntoFile/releases) 页面下载最新的 `PasteIntoFile.exe`

2. **直接运行** (无需安装)
   
   ```
   双击 PasteIntoFile.exe 即可使用
   ```

3. **可选:注册右键菜单** (需要管理员权限)
   
   - 方式一:以管理员身份运行,点击⚙设置按钮,点击"注册"
   - 方式二:命令行运行 `PasteIntoFile.exe /reg`

---

## 使用说明

### 基础用法

#### 方式一:直接运行

1. 复制你想保存的内容(文本或图片)
2. 双击运行 `PasteIntoFile.exe`
3. 在弹出的对话框中输入文件名
4. 点击保存

#### 方式二:右键菜单(推荐)

1. 注册右键菜单(见上方安装步骤)
2. 复制内容到剪贴板
3. 在任意文件夹空白处右键 → 选择 **"粘贴到文件"**
4. 输入文件名并保存

### 命令行参数

```bash
# 指定文件名
PasteIntoFile.exe /filename "MyDocument.txt"

# 指定语言
PasteIntoFile.exe /language zh-CN    # 中文
PasteIntoFile.exe /language en-US    # 英文

# 注册右键菜单 (需管理员权限)
PasteIntoFile.exe /reg

# 注销右键菜单 (需管理员权限)
PasteIntoFile.exe /unreg
```

### 右键菜单集成

#### 注册右键菜单

**方法一:使用设置界面**
1. 以**管理员身份**运行 `PasteIntoFile.exe`
2. 点击主窗口右下角的 ⚙️ **设置**按钮
3. 在"上下文菜单集成"区域点击 **"注册"** 按钮
4. 看到"状态:已注册"提示即成功

**方法二:使用命令行**
```bash
# 以管理员身份运行
PasteIntoFile.exe /reg
```

#### 注销右键菜单

```bash
# 方法一:设置界面点击"注销"按钮
# 方法二:命令行运行
PasteIntoFile.exe /unreg
```

### 设置说明

点击主窗口的 ⚙️ 按钮打开设置页面:

#### 语言设置
- 从下拉菜单选择语言
- 立即生效,无需重启
- 设置自动保存到注册表

#### 文件名格式
支持以下变量:
- `{datetime}` - 完整日期时间,如 `2025-10-06_143025`
- `{date}` - 日期,如 `2025-10-06`
- `{time}` - 时间,如 `143025`
- `{timestamp}` - Unix时间戳,如 `1728198625`

示例:
```
Paste_{datetime}.txt  →  Paste_2025-10-06_143025.txt
Clip_{date}.png       →  Clip_2025-10-06.png
Note_{timestamp}.txt  →  Note_1728198625.txt
```

---

## 文件目录说明

```
PasteIntoFile/
├── PasteIntoFile.sln              # Visual Studio 解决方案文件
├── setup-en.ps1                   # PowerShell 安装脚本 (英文)
├── setup-zh.ps1                   # PowerShell 安装脚本 (中文)
├── /PasteIntoFile/                # 主项目目录
│   ├── Program.cs                 # 程序入口点
│   ├── App.config                 # 应用程序配置
│   ├── app.manifest               # 应用程序清单
│   ├── icon.ico                   # 应用程序图标
│   ├── icon.png                   # 图标 PNG 版本
│   ├── frmMain.cs                 # 主窗体
│   ├── frmMain.Designer.cs        # 主窗体设计器代码
│   ├── frmMain.resx               # 主窗体资源文件
│   ├── frmSettings.cs             # 设置窗体
│   ├── frmSettings.Designer.cs    # 设置窗体设计器代码
│   ├── frmSettings.resx           # 设置窗体资源文件
│   ├── PasteIntoFile.csproj       # 项目文件
│   ├── /Localization/             # 多语言支持模块
│   │   ├── ILanguage.cs           # 语言接口
│   │   ├── EnglishLanguage.cs     # 英文资源
│   │   ├── ChineseLanguage.cs     # 中文资源
│   │   └── LanguageManager.cs     # 语言管理器
│   ├── /Properties/               # 项目属性
│   │   ├── AssemblyInfo.cs        # 程序集信息
│   │   ├── Resources.Designer.cs  # 资源设计器
│   │   └── Resources.resx         # 资源文件
│   ├── /bin/Release/              # 编译输出目录
│   │   └── PasteIntoFile.exe      # 可执行文件 ⭐
│   └── /obj/                      # 编译中间文件
└── README.md                       # 本文档
```

---

## 开发架构

### 技术架构

**应用层**:
- Windows Forms - UI 框架
- .NET Framework 4.7.2 - 运行时

**核心模块**:
- `Program.cs` - 应用入口,注册表操作
- `frmMain` - 主窗口,文件保存逻辑
- `frmSettings` - 设置窗口,配置管理

**多语言系统**:
- `ILanguage` - 语言接口(策略模式)
- `LanguageManager` - 语言管理器(单例模式)
- `EnglishLanguage` / `ChineseLanguage` - 语言实现

**数据存储**:
- Windows Registry - 配置持久化
  - `HKCU\Software\PasteIntoFile\Language`
  - `HKCU\Software\PasteIntoFile\FilenameFormat`
  - `HKCU\Software\Classes\Directory\Background\shell\PasteIntoFile`

### 设计模式

- **单例模式** (Singleton) - `LanguageManager.Current`
- **策略模式** (Strategy) - `ILanguage` 接口
- **工厂模式** (Factory) - `LanguageManager.SetLanguage()`

---

## 使用到的技术

### 开发工具
- [Visual Studio 2022](https://visualstudio.microsoft.com/) - IDE
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) - 开发框架
- [MSBuild](https://docs.microsoft.com/visualstudio/msbuild/msbuild) - 构建工具

### 核心技术
- **Windows Forms** - 桌面应用 UI 框架
- **C#** - 编程语言
- **Windows Registry** - 配置存储
- **Clipboard API** - 剪贴板操作
- **SaveFileDialog** - 文件保存对话框



### 版本历史

- **v2.0** (2025-10-06) - 添加多语言支持和设置页面 （By TikaRa)
- **v1.0** (初始版本) - 基础剪贴板保存功能

---

## 源作者

**EslaMx7**

- GitHub: [@EslaMx7](https://github.com/EslaMx7)
- Repository: [PasteIntoFile](https://github.com/EslaMx7/PasteIntoFile)

*您也可以在[贡献者名单](https://github.com/EslaMx7/PasteIntoFile/graphs/contributors)中参看所有参与该项目的开发者。*

---

## 许可证

该项目签署了 MIT 授权许可,详情请参阅 [LICENSE](https://github.com/EslaMx7/PasteIntoFile/blob/master/LICENSE)

```
MIT License

Copyright (c) 2025 EslaMx7

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files...
```

