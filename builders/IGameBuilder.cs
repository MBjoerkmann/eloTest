using Models;
namespace Builders
{

    public interface IGameBuilder
    {
        void Reset();
        void addPlayer(Player player);
        void removePlayer(Player player);
        Game buildGame();
        
    }
}