using System;

namespace ConsoleGame
{
	// Base character class information
	public class BaseCharacter
	{
		private Vector2 Position;
		private char Avatar;

		public BaseCharacter(char AvatarChar = 'x')
		{
			Position = Vector2.Zero;
			Avatar = AvatarChar;
		}

		public void Move(Vector2 Direction)
		{
			SetCursorPosition();
			Console.Write(" ");
			Position += Direction;

			if(Position.X < 0.0f)
			{
				Position.X = 0.0f;
			}
			else if(Position.X >= Console.WindowWidth)
			{
				Position.X = Console.WindowWidth - 1;
			}

			if(Position.Y < 0.0f)
			{
				Position.Y = 0.0f;
			}
			else if(Position.Y >= Console.WindowHeight)
			{
				Position.Y = Console.WindowHeight - 1;
			}
		}

		public void Move(float X, float Y)
		{
			Move(new Vector2(X, Y));
		}

		public void Draw()
		{
			SetCursorPosition();
			Console.Write(Avatar);
		}

		private void SetCursorPosition()
		{
			Console.SetCursorPosition((int)Position.X, (int)Position.Y);
		}
	}
}

