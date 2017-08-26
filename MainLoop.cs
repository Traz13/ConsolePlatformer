using System;

namespace ConsoleGame
{
	public class MainLoop
	{
		Player MyPlayer;

		public MainLoop ()
		{
			Console.CursorVisible = false;

			MyPlayer = new Player();
		}

		//	Return false on exit command
		public bool Update()
		{
			//	Dont try to read the key unless there is a key available
			if(Console.KeyAvailable)
			{
				//	Store the current key pressed
				ConsoleKey KeyPressed = Console.ReadKey().Key;

				//	Escape Command
				if(KeyPressed == ConsoleKey.Escape)
				{
					return false;
				}

				//	Player Move
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

				//	Spawn an enemny
				if(KeyPressed == ConsoleKey.S)
				{
					SpawnEnemy();
				}
			}

			//	return false to exit;
			return true;
		}

		public void RenderScene()
		{
			//	Draw our player object
			MyPlayer.Draw();
		}

		private void SpawnEnemy()
		{
			//	Randomize a position within bounds of the screen
			Vector2 RandomPosition = new Vector2(new Random().Next(Console.WindowWidth), new Random().Next(Console.WindowHeight));
		}

		public void Shutdown()
		{
			Console.Clear();
			Console.WriteLine("GameOver");
		}
	}
}

