namespace brain_games;

public class UserCommunicator
{
	private string _userName;

	public string UserName
	{
		get => _userName;
		set => _userName = value ?? throw new ArgumentNullException(nameof(value));
	}

	public void GreetUser()
	{
		Console.WriteLine("Welcome to the Brain Games!\nMay I have your name?");
		var userAnswer = Console.ReadLine();
		UserName = userAnswer;
		Console.WriteLine($"Hello, {userAnswer}!");
	}
	
	public void CongratsUser()
	{
		Console.WriteLine($"Congratulations, {UserName}!");
	}

	public void PrintFailedMessage(string message)
	{
		Console.WriteLine(message);
	}
}