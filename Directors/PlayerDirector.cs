using Builders;
using Models;

namespace Directors
{
    public class PlayerDirector
    {
        private IPlayerBuilder _playerBuilder;
        //PlayerDirector(IPlayerBuilder playerBuilder)
        //{
        //    _playerBuilder = playerBuilder;
        //}
        public IPlayerBuilder playerBuilder
        {
            set { _playerBuilder = value; }
        }
        
        public Player setDefaultPlayer()
        {
            _playerBuilder.setName("Default");
            _playerBuilder.setColor("White");
            _playerBuilder.setEloScore(400);
            Player result = _playerBuilder.buildPlayer();
            return result;
        }
        public Player buildWhiteGm()
        {
            _playerBuilder.setName("Magnus");
            _playerBuilder.setColor("White");
            _playerBuilder.setEloScore(2000);
            Player result = _playerBuilder.buildPlayer();
            return result;
        }
        public Player buildBlackGm()
        {
            _playerBuilder.setName("Ian");
            _playerBuilder.setColor("Black");
            _playerBuilder.setEloScore(1600);
            Player result = _playerBuilder.buildPlayer();
            return result;
        }

    }
}