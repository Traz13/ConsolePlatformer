using System;

namespace ConsoleGame
{
	public class Enemy : BaseCharacter 
	{
		public Enemy () : base('E')
		{
		}

		private static Random Randomizer = new Random();

		public void Update()
		{
			
			if(Randomizer.Next(1000) == 0)
			{
				int xDir = Randomizer.Next(2);
				if(xDir == 0)
					xDir = -1;

				int yDir = Randomizer.Next(2);
				if(yDir == 0)
					yDir = -1;

				Move(xDir, yDir);
			}
		}
	}
}

