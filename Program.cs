using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpuChoise;
            string userChoise;
            int RandomInt;
            bool LoopActive = true;

            Random rnd = new Random();

            while (LoopActive == true)
            {
                int cpuScore = 0;
                int userScore = 0;

                while(userScore < 3 && cpuScore < 3)
                {
                    Console.WriteLine("Rock, paper or scissors?");
                    userChoise = Console.ReadLine();
                }

                RandomInt = rnd.Next(1, 4);

                switch (RandomInt)
                {
                    case 1:

                        cpuChoise = "rock";

                        if (userChoise == "rock")
                        {
                            Console.WriteLine("Draw!");
                        }
                        else if (userChoise == "paper")
                        {
                            Console.WriteLine("User wins");
                            userScore++;
                            Console.WriteLine("Users score is" + userScore);
                        }
                        else if (userChoise == "scissors")
                        {
                            Console.WriteLine("Cpu wins");
                            cpuScore++;
                            Console.WriteLine("Computers score is" + cpuScore);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input from user, cpu wins.");
                        }
                        break;

                    case 2:

                        cpuChoise = "scissors";

                        if (userChoise == "rock")
                        {
                            Console.WriteLine("User wins");
                            userScore++;
                            Console.WriteLine("Users score is" + userScore);
                        }
                        else if (userChoise == "paper")
                        {
                            Console.WriteLine("Cpu wins");
                            cpuScore++;
                            Console.WriteLine("Computers score is" + cpuScore);
                        }
                        else if (userChoise == "scissors")
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input from user, cpu wins.");
                        }
                        break;

                    case 3:

                        cpuChoise = "paper";

                        if (userChoise == "rock")
                        {
                            Console.WriteLine("Cpu wins");
                            cpuScore++;
                            Console.WriteLine("Computers score is" + cpuScore);
                        }
                        else if (userChoise == "paper")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (userChoise == "scissors")
                        {
                            Console.WriteLine("User wins");
                            userScore++;
                            Console.WriteLine("Users score is" + userScore);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input from user, cpu wins.");
                        }
                        break;


                }

                if (userScore == 3)
                {
                    Console.WriteLine("User won the game");
                }
                else if (cpuScore == 3)
                {
                    Console.WriteLine("Computer won the game");
                }

            }

        }
    }
}
