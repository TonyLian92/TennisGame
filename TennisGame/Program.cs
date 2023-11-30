using System;

namespace TennisGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Players namesPlayers = new Players();

            namesPlayers.GetPlayerNames();
            
            
            Game game = new Game();

            game.DjokovicWonPoint();
            game.DjokovicWonPoint();
            
            game.SinnerWonPoint();
            game.SinnerWonPoint();
            
            game.DjokovicWonPoint();
            game.DjokovicWonPoint();

            var currentScore = game.GetScore();
            Console.WriteLine($"The score is :\r\n{namesPlayers.Player1}: {currentScore.Djokovic} - {namesPlayers.Player2}: {currentScore.Sinner} \r\n");

            Console.WriteLine($"{game.winner} win the game! \r\n");

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
            
        }
    }
}
