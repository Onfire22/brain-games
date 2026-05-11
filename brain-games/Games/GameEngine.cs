namespace brain_games.Games;

public class GameEngine
{
	private Game _userGame;
	private UserCommunicator _userCommunicator;
	private UserData _userDataValue;
	private const int Attempts = 3;

	public Game UserGame
	{
		get => _userGame;
		set => _userGame = value ?? throw new ArgumentNullException(nameof(value));
	}

	public UserData UserDataValue
	{
		get => _userDataValue;
		set
		{
			var normalizedValue = char.ToLower(value.UserSelect);

			switch (normalizedValue)
			{
				case 'c':
					UserGame = new CalculatorGame();
					break;
				case 'g':
					UserGame = new GCDGame();
					break;
				case 'e':
					UserGame = new IsEvenGame();
					break;
				case 's':
					UserGame = new IsSimpleGame();
					break;
				case 'p':
					UserGame = new ProgressionGame();
					break;
				default:
					throw new Exception("Unknown game type");
			}
		}
	}

	public GameEngine(UserCommunicator userCommunicator, UserData userDataValue)
	{
		_userCommunicator = userCommunicator;
		UserDataValue = userDataValue;
	}
	
	private void GenerateRounds()
	{
		for (int i = 0; i < Attempts; i++)
		{
			var ( result, userAttempt ) = UserGame.PlayGame();
			Console.WriteLine($"Your answer: {userAttempt}");
			if (result == userAttempt)
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				UserGame.IsGameSuccess = false;
				UserGame.IncorrectMessage = $"'{userAttempt}' is wrong answer ;(. Correct answer was '{result}'";
				return;
			}
		}
		
		UserGame.IsGameSuccess = true;
	}
	
	private void GetGameResults()
	{
		if (UserGame.IsGameSuccess)
		{
			_userCommunicator.CongratsUser();
		}
		else
		{
			_userCommunicator.PrintFailedMessage(UserGame.IncorrectMessage);
		}
	}
	
	public void StartGame()
	{
		Console.WriteLine(UserGame.GameRules);
		GenerateRounds();
		GetGameResults();
	}
}