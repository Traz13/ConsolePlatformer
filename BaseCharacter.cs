using System;

namespace ConsoleGame
{
	// Base character class information
	public class BaseCharacter
	{
		//	Local variables
		private Vector2 Position;
		private char Avatar;

		//	Constructor
		//	Base character constructor Char will default to x when no parameter is sent
		//	new BaseCharacter() or newBaseCharacter('y')
		public BaseCharacter(char AvatarChar = 'x')
		{
			//	 Set the default position
			Position = Vector2.Zero;

			//	Store our CHAR to use as our ascii avatar
			Avatar = AvatarChar;
		}

		//	Function
		//	Move by vector
		public void Move(Vector2 Direction)
		{
			//	Move to and clear our currentl locaton
			SetCursorPosition();
			Console.Write(" ");

			//	Move by the ammount passed in as direction
			Position += Direction;

			//	Limit x within the screen width
			if(Position.X < 0.0f)
			{
				Position.X = 0.0f;
			}
			else if(Position.X >= Console.WindowWidth)
			{
				Position.X = Console.WindowWidth - 1;
			}

			//	Limit y within the screen height
			if(Position.Y < 0.0f)
			{
				Position.Y = 0.0f;
			}
			else if(Position.Y >= Console.WindowHeight)
			{
				Position.Y = Console.WindowHeight - 1;
			}
		}

		//	Function
		//	Move by two floats
		public void Move(float X, float Y)
		{
			//	Instead of rewriting the whole function above,
			//		create on execution path for moving in the previous function
			//		by calling into it from this function

			Vector2 MoveVector = new Vector2(X, Y);
			Move(MoveVector);
		}

		//	Function
		public void Draw()
		{
			//	Move to our current position and draw our avatar
			SetCursorPosition();
			Console.Write(Avatar);
		}

		//	Function
		private void SetCursorPosition()
		{
			//	Move the console cursor to our position
			Console.SetCursorPosition((int)Position.X, (int)Position.Y);
		}
	}
}

