// See https://aka.ms/new-console-template for more information
using System;
using GreetingLibrary;

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

string greeting = GreetingHelper.DisplayGreeting(name);
Console.WriteLine(greeting);

