using System;

//	This is where list comes from
using System.Collections.Generic;

namespace ConsoleGame
{
	public class MainLoop
	{
		//	Function
		private Player MyPlayer;
		private List<BaseCharacter> Enemies;
		//private System.Collections.Generic.List<BaseCharacter> Enemies;

		//	Constructor
		public MainLoop ()
		{
			Console.CursorVisible = false;

			Enemies = new List<BaseCharacter>();

			MyPlayer = new Player();

			for(int EnemiesSpawned = 0; EnemiesSpawned < 5; EnemiesSpawned++)
			{
				SpawnEnemy();

				// Wait a frame between spawns to make random a little more random
				System.Threading.Thread.Sleep(1);
			}
		}

		//	Function
		//	Return false on exit command
		public bool Update()
		{
			//	Dont try to read the key unless there is a key available
			if(Console.KeyAvailable)
			{
				bool bInterceptKey = true;

				//	Store the current key pressed
				ConsoleKey KeyPressed = Console.ReadKey(bInterceptKey).Key;

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
			}

			//	return false to exit;
			return true;
		}

		//	Function
		public void RenderScene()
		{
			//	Draw our player object
			MyPlayer.Draw();

			foreach(BaseCharacter Enemy in Enemies)
			{
				Enemy.Draw();
			}
		}

		//	Function
		private void SpawnEnemy()
		{
			//	Randomize a position within bounds of the screen
			Vector2 RandomPosition = new Vector2(new Random().Next(Console.WindowWidth), new Random().Next(Console.WindowHeight));

			BaseCharacter Enemy = new BaseCharacter();
			Enemy.Move(RandomPosition);

			Enemies.Add(Enemy);
		}

		//	Function
		public void Shutdown()
		{
			Enemies.Clear();
			MyPlayer = null;

			Console.Clear();
			Console.WriteLine("GameOver");
		}
	}
}

