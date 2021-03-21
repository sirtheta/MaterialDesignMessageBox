[![.NET](https://github.com/sirtheta/MaterialDesignMessageBox/actions/workflows/dotnet.yml/badge.svg)](https://github.com/sirtheta/MaterialDesignMessageBox/actions/workflows/dotnet.yml)
# MaterialDesignMessageBox

## A simple Messagebox package in the modern material Design.  
Just add this as a NuGet Package in your project.

#### How to use:
Implement a method to call the messagebox like this:
``` 
public bool ShowMessageBox(string messageStr, MessageType type, MessageButtons buttons)
{
  return (bool)new MaterialDesignMessageBox(messageStr, type, buttons).ShowDialog();
}
```
You can choose between three different types of buttons: Ok, Yes/No, Cancel   
and you can choose beteween this message types: Confirmation, Success, Warning, Error  
i.e.: `ShowMessageBox("Button Success clicked", MessageType.Success, MessageButtons.Ok)`

A message with only the button ok, will always return true since one can not close the messagebox without clicking Ok button.  
With messagebuttons Yes/No and Ok/Cancel, the messagebox will return true or false according to the clicked button.  

## Overview of the four messagebox types:  

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
