[![.NET](https://github.com/sirtheta/MaterialDesignMessageBox/actions/workflows/dotnet.yml/badge.svg)](https://github.com/sirtheta/MaterialDesignMessageBox/actions/workflows/dotnet.yml)
# MaterialDesignMessageBox by SirTheta

## A simple Messagebox package in the modern material design.  
Add this as a NuGet Package in your project.

### How to use:
Call the MaterialDesignMessageBox like that:
``` 
MaterialDesignMessageBox.Show("This is a messagebox with information.", MessageType.Info, MessageButtons.Ok);
```
You can choose between three different predefined types of buttons: Ok, Yes/No, Cancel or you can use custom buttons as well.  
For the message type you can choose between this message types: Confirmation, Success, Warning, Error, Question 

i.e.: `MaterialDesignMessageBox.Show("Button Success clicked", MessageType.Success, MessageButtons.Ok)`

The return type of the message box is a `MaterialDesignMessageBoxResult` which has the following definitions:
```
enum MaterialDesignMessageBoxResult
{
    None = 0,
    OK = 1,
    Cancel = 2,
    Yes = 6,
    No = 7
}
```
If you close the messagebox with the escape key, it will return None. 

If you press the return-key the messagebox will return OK or Yes, according of the buttons displayed.

## Overview of some messagebox types:  

### Confirmation  
![confirmation](/images/confirmation.png)  
### Error  
![error](/images/error.png)  
### Info  
![Info](/images/info.png)  
### Success  
![Success](/images/success.png)  
### Warning  
![Warning](/images/warning.png)


## Sample Project:
The MessageBoxTester is a simple project to test how this MessageBox works.