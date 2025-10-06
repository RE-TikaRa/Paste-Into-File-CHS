# PasteIntoFile 中文版一键设置脚本
# Chinese Version One-Click Setup Script

Write-Host "================================" -ForegroundColor Cyan
Write-Host "  PasteIntoFile 中文版设置" -ForegroundColor Cyan
Write-Host "================================" -ForegroundColor Cyan
Write-Host ""

# 检查是否以管理员身份运行
$isAdmin = ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)

if (-not $isAdmin) {
    Write-Host "⚠️  警告: 建议以管理员身份运行此脚本" -ForegroundColor Yellow
    Write-Host "   右键点击 PowerShell -> 以管理员身份运行" -ForegroundColor Yellow
    Write-Host ""
    $continue = Read-Host "是否继续? (Y/N)"
    if ($continue -ne "Y" -and $continue -ne "y") {
        exit
    }
}

# 查找可执行文件
$exePath = $null
$searchPaths = @(
    ".\PasteIntoFile\bin\Release\PasteIntoFile.exe",
    ".\bin\Release\PasteIntoFile.exe",
    ".\PasteIntoFile.exe"
)

foreach ($path in $searchPaths) {
    if (Test-Path $path) {
        $exePath = $path
        break
    }
}

if (-not $exePath) {
    Write-Host "❌ 错误: 找不到 PasteIntoFile.exe" -ForegroundColor Red
    Write-Host "   请先编译项目或将脚本放在正确的目录中" -ForegroundColor Red
    Write-Host ""
    Read-Host "按任意键退出"
    exit
}

Write-Host "📁 找到程序: $exePath" -ForegroundColor Green
Write-Host ""

# 步骤 1: 设置中文
Write-Host "[1/3] 设置界面语言为中文..." -ForegroundColor Cyan
try {
    & $exePath /language zh
    Start-Sleep -Seconds 2
    Write-Host "   ✅ 语言设置成功" -ForegroundColor Green
} catch {
    Write-Host "   ⚠️  语言设置可能失败" -ForegroundColor Yellow
}
Write-Host ""

# 步骤 2: 设置文件名格式
Write-Host "[2/3] 设置文件名格式..." -ForegroundColor Cyan
Write-Host "   默认格式: yyyy-MM-dd HH.mm.ss" -ForegroundColor Gray
Write-Host "   您可以稍后使用以下命令自定义:" -ForegroundColor Gray
Write-Host "   PasteIntoFile.exe /filename yyyy年MM月dd日_HHmmss" -ForegroundColor Gray
try {
    & $exePath /filename "yyyy-MM-dd HH.mm.ss"
    Start-Sleep -Seconds 2
    Write-Host "   ✅ 文件名格式设置成功" -ForegroundColor Green
} catch {
    Write-Host "   ⚠️  文件名格式设置可能失败" -ForegroundColor Yellow
}
Write-Host ""

# 步骤 3: 注册到系统
Write-Host "[3/3] 注册到系统右键菜单..." -ForegroundColor Cyan
try {
    & $exePath /reg
    Start-Sleep -Seconds 2
    Write-Host "   ✅ 系统注册成功" -ForegroundColor Green
} catch {
    Write-Host "   ❌ 系统注册失败 - 请以管理员身份运行" -ForegroundColor Red
}
Write-Host ""

Write-Host "================================" -ForegroundColor Green
Write-Host "  ✅ 设置完成!" -ForegroundColor Green
Write-Host "================================" -ForegroundColor Green
Write-Host ""
Write-Host "📖 使用方法:" -ForegroundColor Yellow
Write-Host "   1. 复制任何文本或图片 (Ctrl+C)" -ForegroundColor White
Write-Host "   2. 在文件夹中右键点击" -ForegroundColor White
Write-Host "   3. 选择 'Paste Into File'" -ForegroundColor White
Write-Host "   4. 设置文件名和扩展名后保存" -ForegroundColor White
Write-Host ""
Write-Host "💡 提示:" -ForegroundColor Yellow
Write-Host "   - 界面将显示为中文" -ForegroundColor White
Write-Host "   - 如需切换语言: PasteIntoFile.exe /language en" -ForegroundColor White
Write-Host "   - 如需注销: PasteIntoFile.exe /unreg" -ForegroundColor White
Write-Host ""
Write-Host "📚 更多帮助请查看:" -ForegroundColor Yellow
Write-Host "   - QUICK_START.md" -ForegroundColor White
Write-Host "   - MULTILANGUAGE.md" -ForegroundColor White
Write-Host "   - USAGE_EXAMPLES.md" -ForegroundColor White
Write-Host ""

Read-Host "按 Enter 键退出"
