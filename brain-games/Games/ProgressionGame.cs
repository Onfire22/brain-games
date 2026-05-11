namespace brain_games.Games;

public class ProgressionGame : Game
{
	private int CorrectAnswer { get; set; }
	
	public override string GameRules => Constants.Constants.ProgressRules;

	public ProgressionGame(int attempts = 3) : base(attempts) {}

	private List<int> BuildProgression()
	{
		var progressionStart = Utils.GetRandomNumber(0, 20);
		var progressionLength = Utils.GetRandomNumber(5, 20);
		var progressionStep = Utils.GetRandomNumber(1, 5);
		var progressionQuestion = Utils.GetRandomNumber(1, progressionLength - 1);

		var progression = new List<int>();

		var begin = progressionStart;
		
		for (int i = 0; i < progressionLength; i += 1)
		{
			progression.Add(begin);
			begin += progressionStep;
		}

		CorrectAnswer = progression[progressionQuestion];

		return progression;
	}

	public override (string, string) PlayGame()
	{
		var progression = BuildProgression();
		var question = string.Join(' ', progression);
		Console.WriteLine($"Question: {question.Replace(CorrectAnswer.ToString(), "..")}");
		var isUserAttemptNumber = int.TryParse(Console.ReadLine(), out int userAttempt);
		if (!isUserAttemptNumber)
		{
			throw new Exception("Your input is not a number");
		}

		return (CorrectAnswer.ToString(), userAttempt.ToString());
	}
}