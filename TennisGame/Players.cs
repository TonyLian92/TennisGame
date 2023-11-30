using System;
using TennisGame.Interfaces;

namespace TennisGame
{
    public class Players : IPlayers
    {
        public string Player1 = "Djokovic";
        public string Player2 = "Sinner";

        public void GetPlayerNames()
        {
            Console.WriteLine($"Player name 1: {Player1}");
            
            Console.WriteLine($"Player name 2: {Player2} \r\n");
           
        }

    }
}
