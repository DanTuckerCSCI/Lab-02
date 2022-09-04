
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