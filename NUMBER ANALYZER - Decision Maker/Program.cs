using System;

Console.WriteLine("Please enter a number between 1 and 100: ");

string usernum = Console.ReadLine();

int userInput = int.Parse(usernum);


//If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”  
//for (userInput = 0; userInput <= 100; userInput+ 2)
    if (userInput % 2 == 1 && userInput < 60)
{
    Console.WriteLine("Odd and less than 60 ");
}
else if (userInput % 2 == 0 && userInput < 24)
{
    Console.WriteLine("Even and less than 25");
}


else if (userInput >= 26 && userInput <= 60)
{
    Console.WriteLine("Even and between 26 and 60 inclusive");
}


else if (userInput % 2 == 0 && userInput > 60)
{
    Console.WriteLine("Even and greater than 60.");
}

else if (userInput % 2 == 1 && userInput > 60)
{
    Console.WriteLine("Odd and greater than 60");



}
//else
//{
//    Console.WriteLine("is an even number.");
//}


