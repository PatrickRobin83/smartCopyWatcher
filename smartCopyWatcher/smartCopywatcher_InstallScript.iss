; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{126AD0EC-B4A8-4DC2-B9AA-AE7025606CA7}
AppName=smartCopyWatcher
AppVersion=1.0
;AppVerName=smartCopyWatch 1.0
AppPublisher=Patrick Robin
DefaultDirName={pf}\smartCopyWatcher
DefaultGroupName=smartCopyWatcher
AllowNoIcons=yes
OutputDir=K:\Privat\Programmierung\VisualStudio\smartCopyWatcher
OutputBaseFilename=smartCopyWatcher_Installer
SetupIconFile=K:\Privat\Programmierung\VisualStudio\smartCopyWatcher\smartCopyWatcher\tigerjapan_Vxl_icon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "K:\Privat\Programmierung\VisualStudio\smartCopyWatcher\smartCopyWatcher\bin\Release\smartCopyWatcher.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\Privat\Programmierung\VisualStudio\smartCopyWatcher\smartCopyWatcher\bin\Release\resources\*"; DestDir: "{app}\resources"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "K:\Privat\Programmierung\VisualStudio\smartCopyWatcher\smartCopyWatcher\bin\Release\smartCopyWatcher.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\smartCopyWatch"; Filename: "{app}\smartCopyWatcher.exe"
Name: "{group}\{cm:UninstallProgram,smartCopyWatch}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\smartCopyWatch"; Filename: "{app}\smartCopyWatcher.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\smartCopyWatch"; Filename: "{app}\smartCopyWatcher.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\smartCopyWatcher.exe"; Description: "{cm:LaunchProgram,smartCopyWatch}"; Flags: nowait postinstall skipifsilent
