using System;

namespace ConsoleGame
{
	//	Derive bahaviour from the base character class
	public class Player : BaseCharacter
	{
		//	Overload the constructor with a different default CHAR
		public Player(char AvatarChar = 'o') : base(AvatarChar)
		{
		}
	}
}