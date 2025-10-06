# PasteIntoFile 简易安装脚本
# 使用 PowerShell 创建自解压安装程序

$AppName = "PasteIntoFile"
$Version = "1.5.1-CHS"
$OutputDir = "installer_output"
$SourceDir = "PasteIntoFile\bin\Release"

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "   PasteIntoFile 安装包制作工具" -ForegroundColor Cyan
Write-Host "   版本: $Version" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# 创建输出目录
if (!(Test-Path $OutputDir)) {
    New-Item -ItemType Directory -Path $OutputDir | Out-Null
    Write-Host "✓ 创建输出目录: $OutputDir" -ForegroundColor Green
}

# 创建临时安装包目录
$TempDir = "$OutputDir\temp_package"
if (Test-Path $TempDir) {
    Remove-Item $TempDir -Recurse -Force
}
New-Item -ItemType Directory -Path $TempDir | Out-Null

# 复制文件
Write-Host "正在复制文件..." -ForegroundColor Yellow
Copy-Item "$SourceDir\PasteIntoFile.exe" $TempDir
Copy-Item "$SourceDir\PasteIntoFile.exe.config" $TempDir
Copy-Item "README.md" $TempDir
Copy-Item "PasteIntoFile\icon.png" $TempDir

# 创建安装说明
$InstallGuide = @"
========================================
粘贴到文件 (PasteIntoFile) v$Version
========================================

安装步骤:
1. 将本文件夹复制到任意位置(推荐: C:\Program Files\PasteIntoFile)
2. 以管理员身份运行 PasteIntoFile.exe
3. 点击右下角的 ⚙ 设置按钮
4. 点击"注册"按钮注册右键菜单

或者使用命令行注册:
  以管理员身份运行: PasteIntoFile.exe /reg

卸载:
  以管理员身份运行: PasteIntoFile.exe /unreg
  然后删除程序文件夹即可

========================================
原作者: Eslam Hamouda
中文版: TiKaRa
GitHub: https://github.com/RE-TikaRa/Paste-Into-File-CHS
哔哩哔哩: https://space.bilibili.com/374412219
========================================
"@

$InstallGuide | Out-File "$TempDir\安装说明.txt" -Encoding UTF8

Write-Host "✓ 文件复制完成" -ForegroundColor Green

# 创建 ZIP 包
$ZipFile = "$OutputDir\$AppName-v$Version-Portable.zip"
if (Test-Path $ZipFile) {
    Remove-Item $ZipFile -Force
}

Write-Host "正在打包..." -ForegroundColor Yellow
Compress-Archive -Path "$TempDir\*" -DestinationPath $ZipFile -CompressionLevel Optimal

Write-Host "✓ 打包完成" -ForegroundColor Green

# 清理临时文件
Remove-Item $TempDir -Recurse -Force

# 显示结果
Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "   打包完成!" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "输出文件: " -NoNewline
Write-Host $ZipFile -ForegroundColor Yellow
Write-Host ""
$ZipInfo = Get-Item $ZipFile
Write-Host "文件大小: $([math]::Round($ZipInfo.Length / 1KB, 2)) KB" -ForegroundColor Cyan
Write-Host ""
Write-Host "你可以直接分发这个 ZIP 文件!" -ForegroundColor Green
Write-Host ""
