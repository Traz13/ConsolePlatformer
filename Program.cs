using System;

namespace ConsoleGame
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Player MyPlayer = new Player();

			Console.CursorVisible = false;

			while(true)
			{
				if(Console.KeyAvailable)
				{
					ConsoleKey KeyPressed = Console.ReadKey().Key;
					if(KeyPressed == ConsoleKey.UpArrow)
					{
						MyPlayer.Move(0, -1);
					}
					if(KeyPressed == ConsoleKey.DownArrow)
					{
						MyPlayer.Move(0, 1);
					}
					if(KeyPressed == ConsoleKey.LeftArrow)
					{
						MyPlayer.Move(-1, 0);
					}
					if(KeyPressed == ConsoleKey.RightArrow)
					{
						MyPlayer.Move(1, 0);
					}
					if(KeyPressed == ConsoleKey.Escape)
					{
						break;
					}
				}

				MyPlayer.Draw();
			}
		}
	}
}
