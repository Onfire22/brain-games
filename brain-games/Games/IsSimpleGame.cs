namespace brain_games.Games;

public class IsSimpleGame : Game
{
	public override string GameRules => Constants.Constants.ISSimpleRules;
	
	public IsSimpleGame(int attempts = 3) : base(attempts) {}
	
	private static bool IsSimple(int num)
	{
		if (num <= 1) return false;

		for (var i = 2; i * i <= num; i++)
		{
			if (num % i == 0) return false;
		}
		
		return true;
	}
	
	public override (string, string) PlayGame()
	{
		var randomNumber = Utils.GetRandomNumber(1, 20);
		Console.WriteLine(randomNumber);
		var isSimple = IsSimple(randomNumber);
		var userAttempt = Console.ReadLine();
		var result = ParseGameValue(isSimple);
		if (userAttempt == null)
		{
			throw new Exception("You should input answer");
		}
		return (result, userAttempt);
	}
}