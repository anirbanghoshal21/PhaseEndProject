using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace PhaseEndProject
{
    class Player
    {
        public int PlayerId;
        public string PlayerName;
        public int PlayerAge;
    }

    interface ITeam
    {
       void Add(Player player);
       void Remove(int playerid);
       Player GetPlayerById(int playerId);
       Player GetPlayerByName(string playerName);
       List<Player> GetAllPlayers();
    }
    class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
            //Console.WriteLine("{0},  {1},   {2} ", oneDayTeam[0].PlayerId, oneDayTeam[0].PlayerName,oneDayTeam[0].PlayerAge);
        }
        public void Remove(int playerId)
        {
            oneDayTeam.Remove(GetPlayerById(playerId));
        }
        public Player GetPlayerById(int playerId)
        {
            Player plr=null;
            int i = 0;
            foreach (Player p in oneDayTeam)
            {
                if (p.PlayerId == playerId)
                {
                    plr = oneDayTeam[i];
                    break;
                }
                i++;
            }
            return plr;
        }
        public Player GetPlayerByName(string playerName)
        {
            Player plr = null;
            foreach (Player p in oneDayTeam)
            {
                if (p.PlayerName.Equals(playerName))
                {
                    plr = p;
                    break;
                }
            }
            return plr;
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

    }
}
