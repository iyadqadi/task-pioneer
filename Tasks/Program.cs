using System;
namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int number;
            Console.WriteLine("How many numbers you want to test?");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            while(n <= 0)
            {
                Console.WriteLine("Invalid input, number must be postive number");
                int.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine("What is the maximun number for generating the numbers randomly?");
            int max;
            int.TryParse(Console.ReadLine(), out max);
            while (max <= 0)
            {
                Console.WriteLine("Invalid input, max must be postive number");
                int.TryParse(Console.ReadLine(), out max);
            }

            Console.Clear();
            Console.WriteLine("\nTesting number to text...\n");

            for (int i = 0; i < n; i++)
            {
                number = random.Next(max);
                Console.WriteLine($"{number} : {number.ToText().ToSentenceCase()}");
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nTesting chess knight moves...\n");

            ChessBoard board = new ChessBoard();
            while (true)
            {
                Console.Write("Please enter the knight position in notation e.g:(D4, c7, A8): ");
                string position = Console.ReadLine();
                if (board.IsValidPosition(position))
                {
                    ChessBoard.Cell cell = new ChessBoard.Cell(position);
                    cell.Piece = Piece.Knight;
                    Console.WriteLine($"The posible moves for the night from :{cell.Notation}");
                    board.PossibleMoves(cell).ForEach(x => Console.WriteLine(x.Notation));
                }else
                {
                    Console.WriteLine($"{position} is not a valid cell position,\n" +
                        $"the cell position must be two charcters, the first is letter from A-H and the second is number from 1-8,\n" +
                        $"for example: A3, b6, D8, F4, G2, etc..");
                }

                ConsoleKeyInfo ch;
                Console.WriteLine("\nPress any key to continue or the Escape (Esc) key to exit: \n");
                ch = Console.ReadKey();
                if (ch.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.Clear();

            }


        }
    }
}
