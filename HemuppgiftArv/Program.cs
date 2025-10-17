using HemuppgiftArv.Game;

namespace HemuppgiftArv
{
    internal class TakePinsGame
    {
        static void Main(string[] args)
        {
            Board board = new Board(); //gör ett nytt objekt i board
            board.SetUp(); //Bestämmer pins genom random

            Console.WriteLine("Välkommen till det revolutionerande AAA-spelet Take Pins");
            Console.Write("Ange ditt namn: ");
            string playerName = Console.ReadLine(); //Välkomstrad + inmatning av screenname

            Console.WriteLine($"Spelet börjar med {board.GetNoPins()} stickor! Du måste ta minst en pinne, men du får inte ta fler än två.\n");//sätter startvärde på pins och etablerar regler

            Player player1 = new HumanPlayer(playerName); //spara screenname
            Player player2 = new ComputerPlayer("Pinnmeister");//statiskt värde för boten

            Player currentPlayer = player1;//spelare 1 börjar.

            while (board.GetNoPins() > 0) //så länge det finns stickor kan du spela
            {
                Console.WriteLine($"\nStickor kvar: {board.GetNoPins()}");

                int pinsToTake = currentPlayer.TakePins(board);
                board.TakePins(pinsToTake);

                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine($"\n{currentPlayer.UserId} tog sista stickan och vinner!");
                    Console.WriteLine($"Grattis {currentPlayer.UserId}!");
                    break;
                }

                currentPlayer = currentPlayer == player1 ? player2 : player1; //sats som alternerar mellan två spelare

                
            }

            Console.WriteLine("\nSpelet är slut!"); //Avslut
        }



    }
}
