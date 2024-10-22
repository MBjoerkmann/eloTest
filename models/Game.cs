namespace Models
{
    public partial class Game 
    {
        public List<Player>? players {get; set;}
        
        public Game()
        {

        }
        public void addPlayer(Player player)
        {
            players.Add(player);
        }
        public void removePlayer(Player player)
        {
            if (players.Count == 0)
            {
                System.Console.WriteLine("No players in game");
            }
            else
            players.Remove(player);
        }
        
    } 
}