//GUESSING GAME

// The following code will allow the user to guess what your favorite number is:
//var userInput = int.Parse(Console.ReadLine());


var r = new Random();
var favNumber = r.Next(1, 50);
var numberOfGuesses = 3;

while (numberOfGuesses > 0)
{
    Console.WriteLine("Feeling lucky? See if you can guess my favorite number between 1 and 50. You get 3 tries. Input your best guess here:");
    var userInput = int.Parse(Console.ReadLine());


    if (userInput < favNumber)
    {
        Console.WriteLine("Sorry! Too low. Try again.");
        numberOfGuesses--;
    }
    else if (userInput > favNumber)
    {
        Console.WriteLine("Oops! Too high. Try again.");
        numberOfGuesses--;
    }
    else
    {
        Console.WriteLine("Ayyy!!! Congratulations! You're good at this!");
        Console.ReadLine();

        return;
    }
}


Console.WriteLine("Oh well try again next time!");

    
