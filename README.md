# Athena

For this tutorial you will need a Raspberry Pi 3 or greater.
I got this idea of creating my own desktop enviornment using C#.  Of course there are several out there, but one thing that bothered me was all the extra applications that I did not need or want. Added to that how about the system automatically get the base GUI for the desktop enviornment from a server if a new version is available.  

Now I got a way below to have raspbian to directly boot and start my desktop, but I also have the ability to code/test the same enviornment on Windows and Mac (Mac will require mono like linux).

I / You can code using Visual Studio and compile your exe applications with only a small dll reference and add Attribute to the main startup Form.  You can then using a Web Site (comming soon) to add or update application you want to have available under the users you control.  You can have dependency (Assemblies only right now) that can be added or updated also using the web site.

For example on user permissions (kind of corny) but user a when they login can only access the calculator and the file explorer but user b when they login can only see/access the calculator.  The file explorer is not available to user b so they cannot run it because it is not on the machine.


Step 1

Download Raspbian Buster Lite from https://www.raspberrypi.org/downloads/raspbian/

Step 2 

Flash your 2GB or larger chip with the OS

Step 3

Boot your raspberry pi and do any setting changes for Network, Locale, Keyboard, etc... using sudo raspi-config
(Reboot if nessessary)

Step 4

There are some base application that we will need
sudo apt update
sudo apt install xserver-xorg-core
sudo apt install xinit
sudo mono-complete

Download the Athena GUI startup app from this Git Repo and place then in a folder under you home directory (/home/pi) called Athena
Athena.Common.Base.exe
Athena.Desktop.API.dll
Newtonsoft.Json.dll
System.Net.Http.Formatting.dll


if you wish to have a boot image instead of the default console output, go to https://github.com/HerbFargus/Raspberry-Pi-Scripts/wiki/Plymouth
I recommend doing this after you have completed the steps to give you system a more polished look.

Step 5

Configure X11 to start loading the graphics driver and the default windows manager

Start X11
sudo nano /etc/rc.local
before the exit 0 line add the below line
/bin/bash startx &

The & is needed so the X11 does not exit

Next we will start the Athena GUI instead of the default X11
sudo nano /etc/X11/xinit/xinitrc
remark the line . /etc/X11/XSession by adding a # at the beginning
add the below lines after the line you remarked out
setterm -blank
xset s off
xset -dpms
mono /home/pi/Athena/Athena.Common.Base.exe

Step 6 

Reboot the pi by typing reboot at the prompt
The system will boot and open the Athena GUI and ask for a login.  
The demo user/password is
user: pi
password: pi

You will see a File Explorer application and a Calculator application to try out.



