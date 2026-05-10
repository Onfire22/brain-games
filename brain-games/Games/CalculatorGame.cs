namespace brain_games.Games;

public class CalculatorGame : Game
{
	private List<char> _operators = ['+', '-', '*'];

	private List<char> Operators => _operators;
	
	public CalculatorGame(string gameRules, int attempts) : base(gameRules, attempts) {}

	private static int CalculateValue(int num1, int num2, char symbol)
	{
		switch (symbol)
		{
			case '+':
				return num1 + num2;
			case '-':
				return num1 - num2;
			case '*':
				return num1 * num2;
			default:
				throw new Exception("Unknown operator");
		}
	}
	
	public override void PlayGame()
	{
		Console.WriteLine(GameRules);
		for (int i = 0; i < Attempts; i++)
		{
			var num1 = Utils.GetRandomNumber(1, 100);
			var num2 = Utils.GetRandomNumber(1, 100);
			var operatorIndex = Utils.GetRandomNumber(0, 2);
			Console.WriteLine($"{num1} {Operators[operatorIndex]} {num2}");
			var result = CalculateValue(num1, num2, Operators[operatorIndex]);
			var isUserAttemptNumber = int.TryParse(Console.ReadLine(), out int userAttempt);
			if (!isUserAttemptNumber)
			{
				throw new Exception("Your input is not a number");
			}
			Console.WriteLine($"Your answer: {userAttempt}");
			if (result == userAttempt)
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				IsGameSuccess = false;
				IncorrectMessage = $"'{userAttempt}' is wrong answer ;(. Correct answer was '{result}'";
				return;
			}
		}
		IsGameSuccess = true;
	}
}