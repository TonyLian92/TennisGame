using System;
using TennisGame.Interfaces;

namespace TennisGame
{
    public class Game : IGame
    {
        static int pointsDjokovic { get; set; } = 0;
        static int pointsSinner { get; set; } = 0;
        public Winners winner { get; private set; }
        static bool IsAdvantagePlay;


        public void DjokovicWonPoint()
        {
            if (!GameIsOver())
            {
                pointsDjokovic++;

                Console.WriteLine("Djokovic win point! \r\n");
                
            }
        }

        public void SinnerWonPoint()
        {
            if (!GameIsOver())
            {
                pointsSinner++;

                Console.WriteLine("Sinner win point! \r\n");

            }
        }

        public (Enum? Djokovic, Enum? Sinner) GetScore()
        {

            if (pointsDjokovic < 4 || pointsSinner < 4)
            {
                return (Djokovic: (Enum)pointsDjokovic, Sinner: (Enum)pointsSinner);
            }
            else if (pointsDjokovic == pointsSinner)
            {
                return (Djokovic: Enum.Deuce, Sinner: Enum.Deuce);
            }
            else if (pointsDjokovic > pointsSinner)
            {
                return (Djokovic: Enum.Advantage, Sinner: null);
            }
            return (Djokovic: null, Sinner: Enum.Advantage);

        }

        public bool GameIsOver()
        {
            if (IsAdvantagePlay)
            {
                int djokovicScoreDifference = pointsDjokovic - pointsSinner;
                int sinnerScoreDifference = pointsSinner - pointsDjokovic;

                return djokovicScoreDifference == 2 || sinnerScoreDifference == 2;
            }

            return pointsDjokovic == 4 || pointsSinner == 4;
        }

    }
}
