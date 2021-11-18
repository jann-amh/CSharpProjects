namespace gameofnim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        Welcome();
        PlayerName();
        int[] arr = { 5, 5, 5 };
        int turn = 3;



        do
        {
            if (turn == 3)
            {
                Console.WriteLine("Player one, make a move ");
                PlayerTurn(turn, arr);
                turn++;
            }
            else
            {
                PlayerTurn(turn, arr);
                turn++;
            }
        }
        while (arr[0] != 0 && arr[1] != 0 && arr[2] != 0);


        Console.ReadLine();
    }
    static void Welcome()
    {
        Console.WriteLine("welcome to nim!");
        Console.WriteLine("RULES: ");
        Console.WriteLine("The game begins with placing five sticks in three different piles.");
        Console.WriteLine("Then the players take turns picking sticks from them until they are empty.");
        Console.WriteLine("The player in turn must pick at least one stick, and they must come from the same pile.");
        Console.WriteLine("The player who has picked the last stick has won the game.");
    }

    static int Game(int[] array)
    {
        int[] arr = { 5, 5, 5 };



        do
        {
            Console.WriteLine("Pick pile A, B or C");

            string choice = Console.ReadLine();
            if (choice == "A")
            {
                Console.WriteLine("how many sticks would you like to remove from A?");
                int.TryParse(Console.ReadLine(), out int input);
                arr[0] = arr[0] - input;
                Console.WriteLine($"Pile A contains {arr[0]}, Pile B contains {arr[1]} & Pile C contains {arr[2]}");
                return arr[0];
            }
            if (choice == "B")
            {
                Console.WriteLine($"how many sticks would you like to remove from B?");
                int.TryParse(Console.ReadLine(), out int input);
                arr[1] = arr[1] - input;
                Console.WriteLine($"Pile A contains {arr[0]}, Pile B contains {arr[1]} & Pile C contains {arr[2]}");
                return arr[1];
            }
            if (choice == "C")
            {
                Console.WriteLine($"how many sticks would you like to remove from C?");
                int.TryParse(Console.ReadLine(), out int input);
                arr[2] = arr[2] - input;
                Console.WriteLine($"Pile A contains {arr[0]}, Pile B contains {arr[1]} & Pile C contains {arr[2]}");
                return arr[2];
            }
            else
            {

                return 0;
            }

        }
        while (arr[0] != 0 && arr[1] != 0 && arr[2] != 0);


    }

    static int PlayerTurn(int turn, int[] arr)
    {
        Game(arr);

        if (turn % 2 == 0)
        {
            Console.WriteLine("Player one, make a move");

            turn++;
            return turn;
        }
        if (turn % 2 == 1)
        {
            Console.WriteLine("Player two, make a move");
            turn++;
            return turn;
        }
        else
        {
            Console.WriteLine("error?");
            return 0;
        }
    }


    static void PlayerName()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Type the name of player1: ");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome " + name + "!");
        Console.WriteLine("Add another player? Type Yes or No");
        string YesOrNo = Console.ReadLine();

        if (YesOrNo == ("Yes"))
        {
            Console.WriteLine("Type the name of player2: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Welcome " + name2 + "!");
        }
        else if (YesOrNo == ("No"))
        {
            Console.WriteLine("You'll be playing against the computer!");

        }
        else
        {
            Console.WriteLine("Your answer must contain either Yes or No");
        }

    }
}