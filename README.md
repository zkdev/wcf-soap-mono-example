# 👋
Lightweight and working example of a **W**indows-**C**ommunication-**F**oundation application using **S**imple-**O**bject-**A**ccess-**P**rotocol specification for Mono framework.

I refuse to switch to an none unix-like operating system just for the sake of WCF application development.
While **.NET** and **.NET Core** is available for Unix **.NET Framework** is not.
Project Mono is an open-source and community driven implementation of the missing **.NET Framework** for unix operating systems, even though they are sponsered by Microsoft.
Further information can be found on their [website](https://www.mono-project.com/).

### Visual Studio
Visual Studio is the goto IDE when it comes to .NET development.
It is available for unix operating systems as well and guess what, it's the lightweight version.
Heads up, lightweight is actually a good thing in my opinion since they Windows version is overloaded and clunky.
Visual Studio for Mac contains some Mono packages already, still I highly recommend to install Mono separately.

... alternatively you can fully drop Visual Studio and extend your understanding by only rely on the command-line and vi (check my [suggestions](https://github.com/zkdev/ultimate-hacky-terminal) for handy command-line tools).

### Usage
I mean, it's a Makefile ...
```
make runHost
```
or custom
```
vi Host/Program.cs
csc CalcService/ICalcService.cs CalcService/CalcService.cs CalcService/Arguments.cs CalcService/Result.cs -target:library
csc Host/Program.cs -reference:ICalcService.dll -out:Host.exe
mono Host.exe
```
