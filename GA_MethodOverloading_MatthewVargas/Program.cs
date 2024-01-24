using System.ComponentModel.Design;
using System.Transactions;

namespace GA_MethodOverloading_MatthewVargas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Would you like to view the scores of your players?");
            Console.WriteLine("Type Y / N");
            if (Console.ReadLine() == "Y" )
            {
                MethodOverloading methodOverloading = new MethodOverloading();

                // Note recent players
                methodOverloading.NoteRecentPlayer("Matthew", 100);
                methodOverloading.NoteRecentPlayer("Jose", 1000); 
                methodOverloading.NoteRecentPlayer("Lilith", 670);
                //methodOverloading.NoteRecentPlayer("22", -4555);
                //methodOverloading.NoteRecentPlayer(22, 40);
                
                //^Invalid input examples commented

                Console.WriteLine("");
                Console.WriteLine("Current players:");
                foreach (var player in methodOverloading.GetOverallPlayersList())
                {
                    
                    Console.WriteLine($" - Player: {player.Name} | Score: {player.Score}");
                }

            }
            else
            {
                Console.WriteLine("Okay then, have a great day");    
            
            } 


        }
    }
}
