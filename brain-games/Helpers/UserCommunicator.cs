namespace brain_games;

public class UserCommunicator
{
	private UserData _userData;

	public UserCommunicator(UserData userData)
	{
		_userData = userData;
	}

	public void GreetUser()
	{
		Console.WriteLine("Welcome to the Brain Games!\nMay I have your name?");
		var userAnswer = Console.ReadLine();
		_userData.UserName = userAnswer;
		Console.WriteLine($"Hello, {userAnswer}!");
	}
	
	public void CongratsUser()
	{
		Console.WriteLine($"Congratulations, {_userData.UserName}!");
	}

	public void PrintFailedMessage(string message)
	{
		Console.WriteLine(message);
	}

	public void GetUserSelect()
	{
		Console.WriteLine("Chose a game you want to play");
		Console.WriteLine("calculate game --c\nGCD game --g\nisEven game --e\nisSimple game --s\nprogress game --p");
		var userKey = Console.ReadKey();
		_userData.UserSelect = userKey.KeyChar;
	}
}