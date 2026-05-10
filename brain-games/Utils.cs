namespace brain_games;

public static class Utils
{
	public static int GetRandomNumber(int min, int max)
	{
		return Random.Shared.Next(min, max);
	}

	public static bool IsEven(int num)
	{
		return num % 2 == 0;
	}
}
