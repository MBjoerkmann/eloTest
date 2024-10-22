using System.Resources;
using Models;

namespace Builders
{
    public class PlayerBuilder : IPlayerBuilder
    {
        private Player? _player;  
        
        public PlayerBuilder()
        {
            reset();
        }
        public void reset()
        {
            _player = new Player();
        }
        public void setName(string name)
        {
            if (_player == null) throw new InvalidOperationException("Player is not initialized");
            _player.Name = name;
        }
        public void setColor(string color)
        {
            if (_player == null) throw new InvalidOperationException("Player is not initialized");
            _player.Color = color;
        }
        public void setEloScore(int score)
        {
            if (_player == null) throw new InvalidOperationException("Player is not initialized");
            _player.eloScore = score;
        }

        public Player buildPlayer()
        {
            if (_player == null){throw new InvalidOperationException("Player is not initialized");}
            Player player = _player;
            reset();
            return player;
        }
        //public PlayerBuilder setName(string name)
        //{
        //    _player.Name = name;
        //    return this;
        //}
        //public PlayerBuilder setColor(string color)
        //{
        //    _player.Color = color;
        //    return this;
        //}
        //public PlayerBuilder setEloScore(int score)
        //{
        //    _player.eloScore = score;
        //    return this;
        //}


    }
}