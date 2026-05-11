using brain_games.Games;
namespace brain_games;

class Program
{
	static void Main(string[] args)
	{
		var userData = new UserData();
		var userCommunicator = new UserCommunicator(userData);

		userCommunicator.GreetUser();
		userCommunicator.GetUserSelect();
		var gameEngine = new GameEngine(userCommunicator, userData);
		gameEngine.StartGame();
	}
}