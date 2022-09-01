
// Console.ReadLine is how we read a line of text
using System.Xml.Linq;

Console.WriteLine("Input first number to be added: ");
var firstNumberAsString = Console.ReadLine();

int firstNum;
while (!int.TryParse(firstNumberAsString, out firstNum))
{
    Console.WriteLine("This is not a number!");
    firstNumberAsString = Console.ReadLine();
}
// ask for second number
Console.WriteLine("Input second number to be added: ");
var secondNumberAsString = Console.ReadLine();

int secondNum;
while (!int.TryParse(secondNumberAsString, out secondNum))
{
    Console.WriteLine("This is not a number!");
    secondNumberAsString = Console.ReadLine();
}

// add them and display the answer
int sum = firstNum + secondNum;
Console.WriteLine("The sum of " + firstNum + " and " + secondNum + " is: " + sum);
