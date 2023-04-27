/*
 *****FIRST EXERCISE****** 
 
Console.WriteLine("Hello World");
Console.WriteLine("Would you like to continue (y/n)?");
string answer = Console.ReadLine();

do
{
    Console.WriteLine("Hello World");
    Console.WriteLine("Would you like to continue (y/n)?");
    answer = Console.ReadLine();
} while (answer == "y");
*/


/*

    *****SECOND EXERCISE******

using System.Globalization;
using System.Reflection.Metadata.Ecma335;


do
{
    Console.WriteLine("Enter a number: ");
    string input = Console.ReadLine();
    int number = int.Parse(input);

    for (int i = 0; i <= number; i++)
    {
        Console.WriteLine(i);

    }
    for (int i = number; i >= 0; i--)
    {
        Console.WriteLine(i);

    }
    Console.WriteLine("Would you like to continue? n/y");
    string answer = Console.ReadLine();
    if (answer == "n")
    {
        break;
    }
} while (true);
Console.WriteLine("Goodbye");
    */


/*
  
  *****THIRD EXERCISE*****

int code = 0;

while ( code != 13579)
{
    Console.WriteLine("Hello, what is the code");
    string input = Console.ReadLine();
    code = int.Parse(input);

}
Console.WriteLine("Welcome to a useless program!!");
Console.ReadKey();
*/


/*
    *****FORTH EXERCISE******
int loginAttempts = 0;
int code = 0;


for (int i = 0; loginAttempts < 5; i++)
{
    while (code != 13579)
    {
        Console.WriteLine("Hello, what is the code");

        string input = Console.ReadLine();
        code = int.Parse(input);

        if (code == 13579)
        {
            Console.WriteLine("login succesful");
            Console.WriteLine("Welcome to a useless program!!");

        }
        else if (code != 13579)
        {
            Console.WriteLine("invalid number please try again.");
            loginAttempts++;
        }
            if (loginAttempts == 5)
            {
                Console.WriteLine("Too many tries.");
                break;
            }                         
        }
        }
        Console.ReadKey();
*/

using System.ComponentModel;

int code = 0;



do
{
    Console.WriteLine("Hello, what is the code");
    string input = Console.ReadLine();
    code = int.Parse(input);

    if(code == 13579)
    {
       break;
    } else
    {
        Console.WriteLine("please try again");
    }
} while (code != 13579);

Console.WriteLine("welcome to a stupid program");