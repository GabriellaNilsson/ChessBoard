using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // for loop for rows
            for (int x = 0; x < num; x++)
            {
                // for loop for columms
                for (int y = 0; y < num; y++)
                {
                    // if statement for rows
                    if ((x + y) % 2 == 0)
                    {
                        // Black squares
                        Console.Write("◼");
                    }

                    // if statement for columms
                    else 
                    {
                        // White squares
                        Console.Write("◻");
                    }
                }
                
                // inserted line break to start a new row
                Console.WriteLine();
                
            }
        }
    }
}