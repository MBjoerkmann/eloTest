using Builders;
using Models;
namespace Directors
{
    public class GameDirector 
    {
        private IGameBuilder _gameBuilder;
        public IGameBuilder gamebuilder
        {
            set { _gameBuilder = value; }
        }
        public IPlayerBuilder playerbuilder
        {
            set { playerbuilder = value; }
        }
        public void buildChessGame()
        {

        }
    }
}