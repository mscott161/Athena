This is the File Explorer application used in the Athena Desktop GUI. During development I use the Project Type Windows Application/EXE. 
You will notice the Attribute for the frmMain object which is what the Desktop GUI uses to identify the startup Form object.  It is ignored
by debugger so you can test the application.  When I want to see the application in my Desktop GUI, I set the project type to Class Library
and upload the dll to the server.  Now when I select the File Explorer from my Desktop GUI is get the new DLL from the server and 
execute it within the Athena Desktop.
