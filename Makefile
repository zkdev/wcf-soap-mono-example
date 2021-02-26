buildHost:
	csc CalcService/ICalcService.cs CalcService/CalcService.cs CalcService/Arguments.cs CalcService/Result.cs -target:library
	csc Host/Program.cs -reference:ICalcService.dll -out:Host.exe

runHost:buildHost
	mono Host.exe
	rm ICalcService.dll

