using System;

namespace DirectionEnum
{
	public static class Extensions
	{
		public static Direction Reverse(this Direction direction)
		{
			switch(direction)
			{
			case Direction.UP: return Direction.DOWN;
			case Direction.DOWN: return Direction.UP;
			case Direction.LEFT: return Direction.RIGHT;
			case Direction.RIGHT: return Direction.LEFT;
			default: return Direction.UP;
			}
		}
	}
	
	public enum Direction {	UP, RIGHT, DOWN, LEFT }
}
