Unit Conversion Library in VB.NET. 
---------
An unity conversion library developed in VB.NET. 
The library is developed in VB.NET, and thus can be used across all .NET languages. 
 
This currently supports the following units to be converted

 1 'Inch -> cm (IntoCm)
    'cm -> Inch (CmtoIn)

 2 'ms -> kmh (MstoKmh)
    'kmh -> ms (KmhtoMs)

 3 'mmHg ->Pa (mmHgtoPa)
    'Pa ->mmHg (PatommHg)

4  'Hp -> W (HptoW)
    'W -> Hp (WtoHp)

5  'J -> Cal (JtoCal)
    'Cal -> J (CaltoJ)


Parameters 
---------
The library has just one function, which takes two parameters. The first parameter is the value to be converted, second parameter is the identifier that contains the initial unit and the unit to be converted.
Valid identifiers are IntoCm ( inches to centimeter), CmtoIn ( centimeter to inches), MstoKmh (miles to kilometers), KmhtoMs (kilometers to miles), mmHgtoPa (mmhg to pascal), PatommHg (pascal to mmhg), HptoW (horsepower to wattage), WtoHp (wattage to horsepower), JtoCal (joule to calorie), and finally CaltoJ ( calorie to joule). However currently JtoCal and CaltoJ are not implemented. 

Returned value
---------
* a floating point value

How to Compile and Use
---------

1. Download, and install visual studio 2015
2. open the source code with .sln file
3. compile/build the library file
4. Use the binary library file in your application 
