namespace brain_games.Games;

public abstract class Game
{
	private int _attempts;
	private bool _isGameSuccess = false;
	private string _incorrectMessage;
	public abstract string GameRules { get; }

	protected int Attempts
	{
		get => _attempts;
		set => _attempts = value < 0 ? 1 : value;
	}

	public bool IsGameSuccess { get; set; }

	public string IncorrectMessage { get; set; }
	
	protected Game(int attempts = 3)
	{
		Attempts = attempts;
	}
	
	public abstract (string, string) PlayGame();
	
	protected static string ParseGameValue(bool value)
	{
		return value ? "yes" : "no";
	}
}
