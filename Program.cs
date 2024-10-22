using controllers;
using Models;
using Builders;
using Directors;

var builder = new PlayerBuilder();
var playerDirector = new PlayerDirector();
playerDirector.playerBuilder = builder;
Player whiteplayer = playerDirector.buildWhiteGm();
Player blackplayer = playerDirector.buildBlackGm();

System.Console.WriteLine($"The expected win percentage for white is: {whiteplayer.CalculateExpectedWinPercentagePlayer(whiteplayer.eloScore, blackplayer.eloScore)}");
whiteplayer.UpdateEloScore(1, blackplayer.eloScore);
System.Console.WriteLine($"The new elo score for white is: {whiteplayer.eloScore}");