namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool play = true;
            while (play)
            {
                String you = "";
                int com = random.Next(1, 4);
                String computer = "";
                while (you != "ROCK" && you != "PAPER" && you != "SCISSORS")
                {
                    Console.Write("Choose ROCK,PAPER or SCISSCORS : ");
                    you = Console.ReadLine();
                    you = you.ToUpper();

                }
                switch (com)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Computer : " + computer);

                switch (you)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("its draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("you lose");
                        }
                        else
                        {
                            Console.WriteLine("you win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("its win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("you draw");
                        }
                        else
                        {
                            Console.WriteLine("you lose");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("its lose");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("you win!");
                        }
                        else
                        {
                            Console.WriteLine("you draw");
                        }
                        break;
                }

                Console.Write("do you want to play again ? (Y/N) ");
                String playagain = Console.ReadLine();
                playagain = playagain.ToUpper();

                if (playagain == "N")
                {
                    play = false;
                }
            }
        }
    }
}
