using Models;
namespace Builders
{
    public interface IPlayerBuilder
    {
        public void reset();
        
        void setName(string name);
        
        void setColor(string color);
        
        void setEloScore(int score);
        
        Player buildPlayer();
        
    }
}