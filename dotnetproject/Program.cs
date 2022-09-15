using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice2 = "yes";
            int choice1= 1;
            
            OneDayTeam odt = new OneDayTeam();
            int pid;
            while (choice2.Equals("yes"))
            {
                Console.Write("\nEnter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
                choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        Player plr = new Player();
                        Console.Write("\nEnter Player Id: ");
                        plr.PlayerId=int.Parse(Console.ReadLine());
                        Console.Write("\nEnter Player Name: ");
                        plr.PlayerName=Console.ReadLine();
                        Console.Write("\nEnter Player Age: ");
                        plr.PlayerAge=int.Parse(Console.ReadLine());
                        odt.Add(plr);
                        Console.Write("\nPlayer is added successfully ");
                        break;
                    case 2:
                        Console.Write("\nEnter Player Id to Remove: ");
                        pid = int.Parse(Console.ReadLine());
                        odt.Remove(pid);
                        Console.Write("\nPlayer is removed successfully ");
                        break;
                    case 3:
                        Console.Write("\nEnter Player Id: ");
                        pid = int.Parse(Console.ReadLine());
                        plr = odt.GetPlayerById(pid);
                        if (plr == null)
                        {
                            Console.Write("\nNo record found ");
                            break;
                        }
                        Console.WriteLine("\n{0}\t{1}\t{2}", plr.PlayerId, plr.PlayerName, plr.PlayerAge);
                        break;
                    case 4:
                        Console.Write("\nEnter Player Name: ");
                        string pname = Console.ReadLine();
                        plr=odt.GetPlayerByName(pname);
                        if (plr == null)
                        {
                            Console.Write("\nNo record found ");
                            break;
                        }
                        Console.WriteLine("\n{0}\t{1}\t{2}",plr.PlayerId, plr.PlayerName, plr.PlayerAge);
                        break;
                    case 5:
                        List<Player> allPlayers = odt.GetAllPlayers();
                        foreach(Player p in allPlayers)
                        {
                            Console.Write("\n{0}\t{1}\t{2}",p.PlayerId, p.PlayerName, p.PlayerAge);
                        }
                        break;
                    default:
                        break;
                }
                Console.Write("\nDo you want to continue (yes/no)?: ");
                choice2 = Console.ReadLine();
            }
        }
    }
}
