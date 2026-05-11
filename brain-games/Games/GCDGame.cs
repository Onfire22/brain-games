namespace brain_games.Games;

public class GCDGame : Game
{
	public override string GameRules => Constants.Constants.GCDRules;
	
	public GCDGame(int attempts = 3) : base(attempts) {}

	private int GetGCD(int a, int b)
	{
		while (b != 0)
		{
			int temp = b;
			b = a % b;
			a = temp;
		}
		return a;
	}

	public override (string, string) PlayGame()
	{
		var num1 = Utils.GetRandomNumber(1, 100);
		var num2 = Utils.GetRandomNumber(1, 100);
		var result = GetGCD(num1, num2);
		Console.WriteLine($"Question: {num1} {num2}");
		var isUserAttemptNumber = int.TryParse(Console.ReadLine(), out int userAttempt);
		if (!isUserAttemptNumber)
		{
			throw new Exception("Your input is not a number");
		}

		return (result.ToString(), userAttempt.ToString());
	}
}