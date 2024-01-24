using System;
using System.Collections.Generic;

namespace GA_MethodOverloading_MatthewVargas
{
    internal class MethodOverloading
    {
        List<string> playerlist = new List<string>();

        public List<string> Playerlist { get { return playerlist; } }

        List<int> scorelist = new List<int>();

        public List<int> Scorelist { get { return scorelist; } }

        // Above are separated pieces of scores and player names

        List<ListedPlayer> overallPlayersList = new List<ListedPlayer>();

        // List for combined data, Players and Score

        public class ListedPlayer
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }
        public List<ListedPlayer> GetOverallPlayersList()
        {
            return overallPlayersList;
        }

        public void AddRecentToList()
        {
            int lastIndex = playerlist.Count - 1;

            overallPlayersList.Add(new ListedPlayer
            {
                Name = playerlist[lastIndex],
                Score = scorelist[lastIndex]
            });
        }

        public void NoteRecentPlayer(string newname, int newscore)
        {
            if (!string.IsNullOrEmpty(newname) && newscore > 0)
            {
                Playerlist.Add(newname);
                Scorelist.Add(newscore);

                AddRecentToList();

                Console.WriteLine("Player added: " + newname + " | Score: " + newscore);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid name or score, please make a valid input");
                Console.WriteLine("");
            }
        }
    }
}
