using System;

//	This is where list comes from
using System.Collections.Generic;

namespace ConsoleGame
{
	public class MainLoop
	{
		//	Private variables
		private Player MyPlayer;
		private List<BaseCharacter> Enemies;

		private int NumEnemies;
		//private System.Collections.Generic.List<BaseCharacter> Enemies;

		//	Constructor
		public MainLoop ()
		{
			NumEnemies = 10;

			Console.CursorVisible = false;

			Enemies = new List<BaseCharacter>();

			MyPlayer = new Player();

			MyPlayer.Move(Console.WindowWidth / 2, Console.WindowHeight / 2);

			for(int EnemiesSpawned = 0; EnemiesSpawned < NumEnemies; EnemiesSpawned++)
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

			foreach(Enemy enemy in Enemies)
			{
				if(enemy.GetPosition() == MyPlayer.GetPosition())
				{
					return false;
				}
				enemy.Update();
			}

			//	return false to exit;
			return true;
		}

		//	Function
		public void RenderScene()
		{
			//	Draw our player object
			MyPlayer.Draw();

			foreach(Enemy enemy in Enemies)
			{
				enemy.Draw();
			}
		}

		//	Function
		private void SpawnEnemy()
		{
			//	Randomize a position within bounds of the screen
			Vector2 RandomPosition = new Vector2(new Random().Next(Console.WindowWidth), new Random().Next(Console.WindowHeight));

			Enemy enemy = new Enemy();
			enemy.Move(RandomPosition);

			Enemies.Add(enemy);
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

