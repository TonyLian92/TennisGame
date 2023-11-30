namespace TennisGame.Interfaces
{
    public interface IGame
    {
        void DjokovicWonPoint();
        void SinnerWonPoint();
        (Enum? Djokovic, Enum? Sinner) GetScore();
        bool GameIsOver();
      
    }
}
