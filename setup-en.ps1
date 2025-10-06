# PasteIntoFile English Version One-Click Setup Script

Write-Host "================================" -ForegroundColor Cyan
Write-Host "  PasteIntoFile English Setup" -ForegroundColor Cyan
Write-Host "================================" -ForegroundColor Cyan
Write-Host ""

# Check if running as administrator
$isAdmin = ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)

if (-not $isAdmin) {
    Write-Host "⚠️  Warning: It's recommended to run this script as Administrator" -ForegroundColor Yellow
    Write-Host "   Right-click PowerShell -> Run as Administrator" -ForegroundColor Yellow
    Write-Host ""
    $continue = Read-Host "Continue anyway? (Y/N)"
    if ($continue -ne "Y" -and $continue -ne "y") {
        exit
    }
}

# Find executable file
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
    Write-Host "❌ Error: Cannot find PasteIntoFile.exe" -ForegroundColor Red
    Write-Host "   Please build the project first or place this script in the correct directory" -ForegroundColor Red
    Write-Host ""
    Read-Host "Press any key to exit"
    exit
}

Write-Host "📁 Found program: $exePath" -ForegroundColor Green
Write-Host ""

# Step 1: Set English
Write-Host "[1/3] Setting interface language to English..." -ForegroundColor Cyan
try {
    & $exePath /language en
    Start-Sleep -Seconds 2
    Write-Host "   ✅ Language set successfully" -ForegroundColor Green
} catch {
    Write-Host "   ⚠️  Language setting may have failed" -ForegroundColor Yellow
}
Write-Host ""

# Step 2: Set filename format
Write-Host "[2/3] Setting filename format..." -ForegroundColor Cyan
Write-Host "   Default format: yyyy-MM-dd HH.mm.ss" -ForegroundColor Gray
Write-Host "   You can customize later with:" -ForegroundColor Gray
Write-Host "   PasteIntoFile.exe /filename yyyy-MM-dd_HHmmss" -ForegroundColor Gray
try {
    & $exePath /filename "yyyy-MM-dd HH.mm.ss"
    Start-Sleep -Seconds 2
    Write-Host "   ✅ Filename format set successfully" -ForegroundColor Green
} catch {
    Write-Host "   ⚠️  Filename format setting may have failed" -ForegroundColor Yellow
}
Write-Host ""

# Step 3: Register to system
Write-Host "[3/3] Registering to system context menu..." -ForegroundColor Cyan
try {
    & $exePath /reg
    Start-Sleep -Seconds 2
    Write-Host "   ✅ System registration successful" -ForegroundColor Green
} catch {
    Write-Host "   ❌ System registration failed - Please run as Administrator" -ForegroundColor Red
}
Write-Host ""

Write-Host "================================" -ForegroundColor Green
Write-Host "  ✅ Setup Complete!" -ForegroundColor Green
Write-Host "================================" -ForegroundColor Green
Write-Host ""
Write-Host "📖 How to use:" -ForegroundColor Yellow
Write-Host "   1. Copy any text or image (Ctrl+C)" -ForegroundColor White
Write-Host "   2. Right-click on a folder" -ForegroundColor White
Write-Host "   3. Select 'Paste Into File'" -ForegroundColor White
Write-Host "   4. Set filename and extension, then save" -ForegroundColor White
Write-Host ""
Write-Host "💡 Tips:" -ForegroundColor Yellow
Write-Host "   - Interface will be in English" -ForegroundColor White
Write-Host "   - To switch language: PasteIntoFile.exe /language zh" -ForegroundColor White
Write-Host "   - To unregister: PasteIntoFile.exe /unreg" -ForegroundColor White
Write-Host ""
Write-Host "📚 For more help, see:" -ForegroundColor Yellow
Write-Host "   - QUICK_START.md" -ForegroundColor White
Write-Host "   - MULTILANGUAGE.md" -ForegroundColor White
Write-Host "   - USAGE_EXAMPLES.md" -ForegroundColor White
Write-Host ""

Read-Host "Press Enter to exit"
