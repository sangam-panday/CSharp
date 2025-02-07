using System;
//Program to find the size of the string
string name = "Sangam";
var howManyBytes = name.Length * sizeof(char);
Console.WriteLine($"The string {name} has {howManyBytes} bytes");

//Size of different integer datatypes
Int16 num1 = 123;
Int32 num2 = 456;
Int64 num3 = 789;
Console.WriteLine($"num1: {num1}, num2: {num2}, num3: {num3}");;
Console.WriteLine($"Size of Int16: {sizeof(Int16)} bytes");
Console.WriteLine($"The maximum value of Int16: {Int16.MaxValue} and minimum value: {Int16.MinValue}");
Console.WriteLine($"Size of Int32: {sizeof(Int32)} bytes");
Console.WriteLine($"The maximum value of Int32: {Int32.MaxValue} and minimum value: {Int32.MinValue}");
Console.WriteLine($"Size of Int64: {sizeof(Int64)} bytes");
Console.WriteLine($"The maximum value of Int64: {Int64.MaxValue} and minimum value: {Int64.MinValue}");
//It can also be written as
short num4 = 123;
int num5 = 456;
long num6 = 789;
Console.WriteLine($"num4: {num4}, num5: {num5}, num6: {num6}");

//Unsigned datatypes of above integers
UInt16 num7 = 123;
UInt32 num8 = 456;
UInt64 num9 = 789;
ushort num10 = 123;
uint num11 = 456;
ulong num12 = 789;
Console.WriteLine($"num7: {num7}, num8: {num8}, num9: {num9}");
Console.WriteLine($"num10: {num10}, num11: {num11}, num12: {num12}");

//Size of different floating point datatypes
Single num13 = 123.456f;
Double num14 = 456.789;
Decimal num15 = 789.123m;
Console.WriteLine($"num13: {num13}, num14: {num14}, num15: {num15}");

//Above can also be written as
float num16 = 123.456f;
double num17 = 456.789;
decimal num18 = 789.123m;
Console.WriteLine($"num16: {num16}, num17: {num17}, num18: {num18}");

//Understand Accuracy
float a = 1.78986380830029492956829698978655434342477f; //7 digits Maximum
double b = 1.78986380830029492956829698978655434342477; //15 digits Maximum
decimal c = 1.78986380830029492956829698978655434342477m; //29 digits Maximum
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

//get size of predefined datatypes
Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
Console.WriteLine($"Size of sbyte: {sizeof(sbyte)} bytes");
Console.WriteLine($"Size of char: {sizeof(char)} bytes");
