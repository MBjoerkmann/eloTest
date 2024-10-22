using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;

namespace Models
{
    public partial class Player
    {
        public string Name { get; set; } = "";
        public string Color { get; set; } = "";
        public int eloScore { get; set; } = 400;

        public Player() 
        {
        }
        //this method calculates the expected percentage of games playerA will win. 
        public double CalculateExpectedWinPercentagePlayer(int playerA_elo, int playerB_elo)
        {
            double expectedScore = 1 / (1 + Math.Pow(10, (playerB_elo - playerA_elo) / 400));
            return expectedScore;
        }
        /// <summary>
        /// Update Player Eloscore, a loss is 0, a win is 1, and a draw is 0.5
        /// </summary>
        /// <param name="ActualResult"></param>
        /// <param name="opponentElo"></param>
        public void UpdateEloScore(double ActualResult, int opponentElo)
        {
            int Kfactor = 32;
            double updatedElo = eloScore + (Kfactor * (ActualResult - CalculateExpectedWinPercentagePlayer(eloScore, opponentElo))); 
            eloScore = Convert.ToInt32(updatedElo);
        }
    }
}