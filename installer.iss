; PasteIntoFile 安装脚本 - Inno Setup
; 中文汉化版 By TiKaRa

#define MyAppName "粘贴到文件 (PasteIntoFile)"
#define MyAppVersion "1.5.1"
#define MyAppPublisher "Eslam Hamouda (CHS By TiKaRa)"
#define MyAppURL "https://github.com/RE-TikaRa/Paste-Into-File-CHS"
#define MyAppExeName "PasteIntoFile.exe"

[Setup]
; 应用基本信息
AppId={{F6F4215C-6CD7-4279-9C4C-C2DA9A823D0C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
; 安装路径
DefaultDirName={autopf}\PasteIntoFile
DefaultGroupName=粘贴到文件
DisableProgramGroupPage=yes
; 许可证
LicenseFile=LICENSE
; 输出配置
OutputDir=installer_output
OutputBaseFilename=PasteIntoFile-v1.5.1-CHS-Setup
; 压缩
Compression=lzma2/max
SolidCompression=yes
; 界面配置
WizardStyle=modern
SetupIconFile=PasteIntoFile\icon.ico
UninstallDisplayIcon={app}\{#MyAppExeName}
; 权限
PrivilegesRequired=admin
; 架构
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible

[Languages]
Name: "chinesesimplified"; MessagesFile: "compiler:Languages\ChineseSimplified.isl"

[Tasks]
Name: "desktopicon"; Description: "创建桌面快捷方式"; GroupDescription: "附加图标:"; Flags: unchecked
Name: "registercontextmenu"; Description: "注册右键菜单(推荐)"; GroupDescription: "系统集成:"; Flags: checkedonce

[Files]
Source: "PasteIntoFile\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "PasteIntoFile\bin\Release\PasteIntoFile.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "PasteIntoFile\icon.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "README.md"; DestDir: "{app}"; Flags: ignoreversion; DestName: "README.txt"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\卸载 {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Parameters: "/reg"; Description: "注册右键菜单"; Flags: runhidden; Tasks: registercontextmenu
Filename: "{app}\{#MyAppExeName}"; Description: "运行 {#MyAppName}"; Flags: nowait postinstall skipifsilent

[UninstallRun]
Filename: "{app}\{#MyAppExeName}"; Parameters: "/unreg"; Flags: runhidden

[Code]
procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssPostInstall then
  begin
    // 安装完成后的操作
  end;
end;

procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
begin
  if CurUninstallStep = usPostUninstall then
  begin
    // 卸载后清理
  end;
end;
