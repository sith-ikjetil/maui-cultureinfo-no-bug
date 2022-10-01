# maui-cultureinfo-no-bug
A DateTime culture specific "nb-NO" does not yield correct datetime string on iOS using MAUI.

This will yield the wrong datetime for Norwegian culture info. 
This has only been tested wrong on iOS 15.4. 
It works on Android and Windows. 
  
dotnet --version gives me 6.0.401 
 
It should be: 01.10.2022 16:00:28 
But it is: 10/1/2022 4:00:28 PM  
(date and time is example only) 
