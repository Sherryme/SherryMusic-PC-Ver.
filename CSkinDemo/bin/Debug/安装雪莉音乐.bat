@echo off
set Program=%~dp0\ѩ������.exe
set LnkName=ѩ������
set Desc=���ƽ̨��һ�γ���
 
if not defined WorkDir call:GetWorkDir "%Program%"
(echo Set WshShell=CreateObject("WScript.Shell"^)
echo strDesKtop=WshShell.SpecialFolders("DesKtop"^)
echo Set oShellLink=WshShell.CreateShortcut(strDesKtop^&"\%LnkName%.lnk"^)
echo oShellLink.TargetPath="%Program%"
echo oShellLink.WorkingDirectory="%WorkDir%"
echo oShellLink.WindowStyle=1
echo oShellLink.Description="%Desc%"
echo oShellLink.Save)>makelnk.vbs
echo �����ݷ�ʽ�����ɹ���
makelnk.vbs
del /f /q makelnk.vbs
exit
goto :eof
:GetWorkDir
set WorkDir=%~dp1
set WorkDir=%WorkDir:~,-1%
goto :eof