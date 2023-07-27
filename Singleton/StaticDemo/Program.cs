// See https://aka.ms/new-console-template for more information


using StaticDemo;
using System;

double celcius = 37; double fahrenheit = 98.6;
Console.WriteLine("Value of {0} celcius to fahrenheit is {1}",
    celcius, Converter.ToFahrenheit(celcius));
Console.WriteLine("Value of {0} fahrenheit to celcius is {1}",
    fahrenheit, Converter.ToCelcius(fahrenheit));
Console.ReadLine();



