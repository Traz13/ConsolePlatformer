﻿using System;

namespace ConsoleGame
{
	public struct Vector2
	{
		public float X;
		public float Y;

		public static Vector2 Zero = new Vector2(0.0f, 0.0f);

		public Vector2(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}

		public Vector2(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public static Vector2 operator +(Vector2 v1, Vector2 v2)
		{
			return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
		}

		public static Vector2 operator -(Vector2 v1, Vector2 v2)
		{
			return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
		}

		public static Vector2 operator *(Vector2 v1, float m)
		{
			return new Vector2(v1.X * m, v1.Y * m);
		}

		public static float operator *(Vector2 v1, Vector2 v2)
		{
			return v1.X * v2.X + v1.Y * v2.Y;
		}

		public static Vector2 operator /(Vector2 v1, float m)
		{
			return new Vector2(v1.X / m, v1.Y / m);
		}

		public static float Distance(Vector2 v1, Vector2 v2)
		{
			return (float)Math.Sqrt(Math.Pow(v1.X - v2.X, 2) + Math.Pow(v1.Y - v2.Y, 2));
		}

		public float Length()
		{
			return (float)Math.Sqrt(X * X + Y * Y);
		}
	}
}
