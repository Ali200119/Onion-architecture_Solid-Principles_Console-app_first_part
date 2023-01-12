using System;
namespace Service.Helpers
{
	public static class Extentions
	{
		public static void WriteConsole(this ConsoleColor color, string text)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(text);
			Console.ResetColor();
		}
	}
}