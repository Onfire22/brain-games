using brain_games.Games;
namespace brain_games;


class Program
{
	static void Main(string[] args)
	{
		var user = new UserCommunicator();
		user.GreetUser();
		var game = new CalculatorGame("What is the result of the expression?", 3);
		game.PlayGame();
		if (game.IsGameSuccess)
		{
			user.CongratsUser();
		}
		else
		{
			user.PrintFailedMessage(game.IncorrectMessage);
		}
	}
}