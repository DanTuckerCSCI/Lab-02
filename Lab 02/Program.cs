using ConsoleTables;
using System.Xml.Linq;
// ask for fist number to be added
Console.WriteLine("Input first number to be added: ");
var firstNumberAsString = Console.ReadLine();

int firstNum;
// validate
while (!int.TryParse(firstNumberAsString, out firstNum))
{
    Console.WriteLine("This is not a number!\nInput first number to be added: ");
    firstNumberAsString = Console.ReadLine();
}
// ask for second number
Console.WriteLine("Input second number to be added: ");
var secondNumberAsString = Console.ReadLine();

int secondNum;
//validate
while (!int.TryParse(secondNumberAsString, out secondNum))
{
    Console.WriteLine("This is not a number!\nInput second number to be added: ");
    secondNumberAsString = Console.ReadLine();
}

// add them and display the answer
int sum = firstNum + secondNum;
Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " is: " + sum);

// Part 2 Multiplication tables
// ask for fist number to be multiplied
Console.WriteLine("----------------------------------------------\n" +
    "Now we will make multiplication tables \n----------------------------------------------");
Console.WriteLine("Input first number: ");
var thirdNumberAsString = Console.ReadLine();

int thirdNum;
// validate
while (!int.TryParse(thirdNumberAsString, out thirdNum))
{
    Console.WriteLine("This is not a number!\nInput first number to be multiplied: ");
    thirdNumberAsString = Console.ReadLine();
}
// ask for second number to multiply to
Console.WriteLine("Input number to muliply to: ");
var fourthNumberAsString = Console.ReadLine();

int fourthNum;
//validate
while (!int.TryParse(fourthNumberAsString, out fourthNum))
{
    Console.WriteLine("This is not a number!\nInput second number to be multiplied: ");
    fourthNumberAsString = Console.ReadLine();
}
// for loop to get numbers
for (int i = 0; i < fourthNum+1; i++)
{
    int total = i * thirdNum;
    Console.WriteLine(thirdNum + " * " + i + " = " + total);
}
Console.WriteLine("-----------Next comes the data types table-----------\n");
Console.WriteLine("Press Enter to continue\n");
Console.ReadLine();
//----------------------------------Section 3-----------------------------------------
Console.WriteLine("| Type \t|\tBytes of Memory \t|\t Min \t\t\t\t\t|\tMax \t\t\t\t\t|");
Console.WriteLine($"| sbyte\t|\t {sizeof(sbyte)}\t\t\t|\t {sbyte.MinValue}\t\t\t\t\t|\t{sbyte.MaxValue} \t\t\t\t\t|");
Console.WriteLine($"| byte \t|\t {sizeof(byte)} \t\t\t|\t {byte.MinValue} \t\t\t\t\t|\t {byte.MaxValue} \t\t\t\t\t|");
Console.WriteLine($"| short\t|\t {sizeof(short)}\t\t\t|\t{short.MinValue}  \t\t\t\t|\t {short.MaxValue} \t\t\t\t\t|");
Console.WriteLine($"| ushort|\t {sizeof(ushort)} \t\t\t|\t {ushort.MinValue} \t\t\t\t\t|\t {ushort.MaxValue} \t\t\t\t\t|");
Console.WriteLine($"| int \t|\t {sizeof(int)} \t\t\t|\t {int.MinValue} \t\t\t\t|\t {int.MaxValue} \t\t\t\t|");
Console.WriteLine($"| uint \t|\t {sizeof(uint)} \t\t\t|\t {uint.MinValue} \t\t\t\t\t|\t {uint.MaxValue} \t\t\t\t|");
Console.WriteLine($"| long \t|\t {sizeof(long)} \t\t\t|\t {long.MinValue} \t\t\t|\t {long.MaxValue} \t\t\t|");
Console.WriteLine($"| ulong\t|\t {sizeof(ulong)} \t\t\t|\t {ulong.MinValue} \t\t\t\t\t|\t {ulong.MaxValue} \t\t\t|");
Console.WriteLine($"| float\t|\t {sizeof(float)} \t\t\t|\t {float.MinValue} \t\t\t|\t {float.MaxValue} \t\t\t\t|");
Console.WriteLine($"| double|\t {sizeof(double)} \t\t\t|\t {double.MinValue} \t\t|\t{double.MaxValue} \t\t\t");
Console.WriteLine($"| decimal|\t {sizeof(decimal)} \t\t\t|\t {decimal.MinValue} \t|\t{decimal.MaxValue} \t\t");
        
//--------------------------------Section 4-------------------------------
Console.WriteLine("\n-----------Now we will try a calculator-------------");




