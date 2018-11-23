using System;

public static class ActionExtensions
{
	public static void NullSafe(this Action action)
	{
		action?.Invoke();
	}

	public static void NullSafe<T>(this Action<T> action, T arg)
	{
		action?.Invoke(arg);
	}
}

