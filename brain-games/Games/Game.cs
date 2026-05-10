namespace brain_games.Games;

public abstract class Game
{
	private string _gameRules;
	private int _attempts;
	private bool _isGameSuccess = false;
	private string _incorrectMessage;

	protected string GameRules { get; set; }

	protected int Attempts
	{
		get => _attempts;
		set => _attempts = value < 0 ? 1 : 3;
	}

	public bool IsGameSuccess { get; set; }

	public string IncorrectMessage { get; set; }
	
	protected Game(string gameRules, int attempts = 3)
	{
		GameRules = gameRules;
		Attempts = attempts;
	}
	
	public abstract void PlayGame();
}
