$msbuild = "C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe"
$solution = "C:\PasteIntoFile\PasteIntoFile.sln"

Write-Host "Starting build..." -ForegroundColor Green
& $msbuild $solution /p:Configuration=Release /p:Platform="Any CPU" /v:minimal /nologo

if ($LASTEXITCODE -eq 0) {
    Write-Host "`nBuild succeeded!" -ForegroundColor Green
    Write-Host "`nOutput file:" -ForegroundColor Cyan
    Get-Item "C:\PasteIntoFile\PasteIntoFile\bin\Release\PasteIntoFile.exe" | Format-List Name, Length, LastWriteTime
} else {
    Write-Host "`nBuild failed with exit code: $LASTEXITCODE" -ForegroundColor Red
}
