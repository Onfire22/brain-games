namespace brain_games.Games;

public class IsEvenGame : Game
{
	public IsEvenGame(string gameRules, int attempts) : base(gameRules, attempts)
	{
		
	}

	private static bool ParseUserAnswer(string? answer)
	{
		if (answer == null) return false;
		
		return answer == "yes" ? true : false;
	}

	public override void PlayGame()
	{
		Console.WriteLine(GameRules);
		for (int i = 0; i < Attempts; i++)
		{
			var randomNumber = Utils.GetRandomNumber(1, 100);
			Console.WriteLine(randomNumber);
			var result = Utils.IsEven(randomNumber);
			var userAttempt = Console.ReadLine();
			if (result == ParseUserAnswer(userAttempt))
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				IsGameSuccess = false;
				IncorrectMessage =
					$"'{userAttempt}' is wrong answer ;(. Correct answer was '{(userAttempt == "yes" ? "no" : "yes")}'.";
				return;
			}
		}
		
		IsGameSuccess = true;
	}
}
