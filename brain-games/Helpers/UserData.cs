namespace brain_games;

public class UserData
{
	private string _userName;

	public string UserName
	{
		get => _userName;
		set => _userName = value ?? throw new ArgumentNullException(nameof(value));
	}

	public char UserSelect
	{
		get => field;
		set => field = char.ToLower(value);
	}
}
