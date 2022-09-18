//Declare variables and then initialize to zero.

using System;
using System.IO;

int num1 = 0; int num2 = 0; int num3 = 0; int num4 = 0; int num5 = 0; int num6 = 0;

//Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("--------------------------");

//Ask the user to type the first number.
Console.WriteLine("Enter coordinate x of dot A");
num1 = Convert.ToInt32(Console.ReadLine());

//Ask the user to type the second number.
Console.WriteLine("Enter coordinate y of dot A");
num2 = Convert.ToInt32(Console.ReadLine());

//Ask the user to type the third number.
Console.WriteLine("Enter coordinate x of dot B");
num3 = Convert.ToInt32(Console.ReadLine());

//Ask the user to type the fourth number.
Console.WriteLine("Enter coordinate y of dot B");
num4 = Convert.ToInt32(Console.ReadLine());

//Ask the user to type the fifth number.
Console.WriteLine("Enter coordinate x of dot C");
num5 = Convert.ToInt32(Console.ReadLine());

//Ask the user to type the sixth number.
Console.WriteLine("Enter coordinate y of dot C");
num6 = Convert.ToInt32(Console.ReadLine());

//To do: validate the data.

double AB = Math.Sqrt(Math.Pow(num3 - num1, 2) + Math.Pow(num4 - num2, 2));
Convert.ToDouble(AB);
Console.WriteLine("Length of AB is: " + AB);

double BC = Math.Sqrt(Math.Pow(num5 - num3, 2) + Math.Pow(num6 - num4, 2));
Convert.ToDouble(BC);
Console.WriteLine("Length of BC is: " + BC);

double AC = Math.Sqrt(Math.Pow(num5 - num1, 2) + Math.Pow(num6 - num2, 2));
Convert.ToDouble(AC);
Console.WriteLine("Length of AC is: " + AC);

if (AB == BC && BC == AC && AC == AB)
{
    Console.WriteLine("This is an equilateral triangle.");
}
else
{
    Console.WriteLine("This is NOT an equilateral triangle.");
}

if (AB == BC || AB == AC || BC == AC)
{
    Console.WriteLine("This is an isosceles triangle.");
}
else
{
    Console.WriteLine("This is NOT an isosceles triangle.");
}
double delta = 0.01;

if (Math.Abs (AB*AB-(BC*BC+AC*AC)) <=delta || Math.Abs (BC * BC - (AC * AC + AB * AB)) <= delta || Math.Abs(AC * AC - (AB * AB + BC * BC)) <= delta)
{
    Console.WriteLine("This is a right triangle.");
}
else
{
    Console.WriteLine("This is NOT a right triangle.");
}
double Perimeter = (AB + BC + AC);
Console.WriteLine("Perimeter is: " + Perimeter);

for (int i = 0; i < Perimeter; i += 2)
{
    Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:" +i);
}

//Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
