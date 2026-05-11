namespace brain_games.Games;

public class IsEvenGame : Game
{
	public override string GameRules => Constants.Constants.IsEvenRules;
	
	public IsEvenGame(int attempts = 3) : base(attempts) {}

	private static bool IsEven(int num)
	{
		return num % 2 == 0;
	}

	public override (string, string) PlayGame()
	{
		var randomNumber = Utils.GetRandomNumber(1, 100);
		Console.WriteLine(randomNumber);
		var isEven = IsEven(randomNumber);
		var userAttempt = Console.ReadLine();
		var result = ParseGameValue(isEven);
		if (userAttempt == null)
		{
			throw new Exception("You should input answer");
		}
		return (result, userAttempt);
	}
}
