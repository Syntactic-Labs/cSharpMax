using System;

namespace TheGreatDabbling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Random r = new Random();
                Console.WriteLine("Choose r for rock, p for paper, or s for scissors?");
                string user = Console.ReadLine();
                string[] responses = {
                    "Do you know how to read?", "You might need to ask your mom for help!", "Not everyone is good at this... clearly."
                };//0     1          2
                string[] computer = { "rock", "paper", "scissors" };
                int ridx = r.Next(responses.Length);
                int cidx = r.Next(computer.Length);
                foreach (var comp in computer)
                {
                    Console.WriteLine($"{comp}");
                }

                
                
                Console.WriteLine("Do you want to keep playing? yes or no: ");
            } while (Console.ReadLine() == "yes");   
                
        }
    }
}
