﻿# CoPo

This Application is a Controlling Panel.

[The Project]
You can setup the service on multiple PC and controlling them on a ASP.NET website.
The service only collects these datas: PC name, OS Name, OS Version, CPU info, Input Locale, System Locale, Disk Capacity and Total Physical Memory.

You are able to Shut down a Pc too.

Login is required with admin, admin.

Technologies what I used in the project: WCF, Windows Service(NT), ASP.NET Core.

[How to Install]
The best is to use Cmd in Admin to run this service.
You need to go to the Service/WindowsService1/bin/Debug folder.
Next Copy this code: C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe WindowsService1.exe.
It installs the service to your Pc and after that use the: net start Service1 command.

You don't need to do anything in the client, just start the project.

You can see now your PC datas.
You can add other computers wich has the service running but you can only add them by manually.

Release History

4/15/2020 - Preview

- Able to connect to WCF and query data
- Able to login with admin - admin
- Able to see the PC details
- WCF messages are not secured
- Using cookies for authentication
- If you are not logged in, you are not able see the computers
