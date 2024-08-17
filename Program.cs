using System;

namespace TickCross
{
    class Game
    {
        static void Main(string[] args)
        {
            int player = 0;
            bool iswin = false;
            string[,] num = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
            while (!iswin)
            {
                Console.Clear();
                for (int a = 0; a <= 2; a++)
                {
                    for (int b = 0; b <= 2; b++)
                    {
                        Console.Write(num[a, b] + "|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nEnter your position player (1 to 9): "+player);
                int position = Convert.ToInt32(Console.ReadLine());
                int i=0, j=0;
                if (position == 1)
                {
                    i = 0;
                    j = 0;
                }
                else if(position == 2)
                {
                    i = 0;
                    j = 1;
                }
                else if (position == 3)
                {
                    i = 0;
                    j = 2;
                }
                else if (position == 4)
                {
                    i = 1;
                    j = 0;
                }
                else if (position == 5)
                {
                    i = 1;
                    j = 1;
                }
                else if (position == 6)
                {
                    i = 1;
                    j = 2;
                }
                else if (position == 7)
                {
                    i = 2;
                    j = 0;
                }
                else if (position == 8)
                {
                    i = 2;
                    j = 1;
                }
                else if (position == 9)
                {
                    i = 2;
                    j = 2;
                }
                else
                {
                    Console.WriteLine("Error: please enter valid number");
                }
                //Start
                if (player == 1)
                {
                    num[i, j] = "x";
                }
                else
                {
                    num[i, j] = "o";
                }
                //horizontal win
                if (num[0, 0] == "x" && num[0, 1] == "x" && num[0, 2] == "x")
                {
                    iswin = true;
                }
                else if (num[0, 0] == "o" && num[0, 1] == "o" && num[0, 2] == "o")
                {
                    iswin = true;
                }
                else if (num[0, 1] == "x" && num[1, 1] == "x" && num[1, 2] == "x")
                {
                    iswin = true;
                }
                else if (num[0, 1] == "o" && num[1, 1] == "o" && num[1, 2] == "o")
                {
                    iswin = true;
                }
                else if (num[0, 2] == "x" && num[1, 2] == "x" && num[2, 2] == "x")
                {
                    iswin = true;
                }
                else if (num[0, 2] == "o" && num[1, 2] == "0" && num[2, 2] == "o")
                {
                    iswin = true;
                }
                //vertical win
                else if (num[0, 0] == "x" && num[1, 0] == "x" && num[2, 0] == "x")
                {
                    iswin = true;
                }
                else if (num[0, 0] == "o" && num[1, 0] == "o" && num[2, 0] == "o")
                {
                    iswin = true;
                }
                else if (num[0, 1] == "x" && num[1, 1] == "x" && num[2, 1] == "x")
                {
                    iswin = true;
                }
                else if (num[0, 1] == "o" && num[1, 1] == "o" && num[2, 1] == "o")
                {
                    iswin = true;
                }
                else if (num[0, 2] == "x" && num[1, 2] == "x" && num[2, 2] == "x")
                {
                    iswin = true;
                }
                else if (num[0, 2] == "o" && num[1, 2] == "o" && num[2, 2] == "o")
                {
                    iswin = true;
                }
                //diagnol win
                else if (num[0, 0] == "x" && num[1, 1] == "x" && num[2, 2] == "x")
                {
                    iswin = true;
                }
                else if (num[0, 0] == "o" && num[1, 1] =="o" && num[2,2] == "o")
                {
                    iswin = true;
                }
                if (player == 0&& !iswin)
                {
                    player++;
                }
                else if(player == 1&& !iswin)
                {
                    player--;
                }
                Console.WriteLine();
                Console.WriteLine("Player "+player+" Wins Congrats..!!");
            }
        }
    }
}