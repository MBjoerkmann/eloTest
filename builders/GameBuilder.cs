using Models;
using System.Collections.Generic;

namespace Builders
{
    public class GameBuilder : IGameBuilder
    {
        private Game _game;
        public GameBuilder()
        {
            Reset();
        }
        public void addPlayer(Player player)
        {
            _game.players.Add(player);

        }
        public void removePlayer(Player player)
        {
            _game.players.Remove(player);
        }
        public Game buildGame()
        {
            Game game = _game;
            game.players = game.players;
            Reset();
            return game;
        }

        public void Reset()
        {
            _game = new Game();
        }
    }
}