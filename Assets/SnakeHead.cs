using UnityEngine;
using System.Collections;
using DirectionEnum;

public class SnakeHead
{
	private ObjMovements movements;
	private Direction direction;
	private GameObject gameObject;
	
	public SnakeHead (GameObject gameObject)
	{
		this.gameObject = gameObject;
		this.direction = Direction.UP;
		this.movements = new ObjMovements(this.gameObject);
	}
	
	public void MoveForward()
	{
		switch(this.direction)
		{
		case Direction.UP: movements.MoveUp(); break;
		case Direction.DOWN:movements.MoveDown(); break;
		case Direction.RIGHT: movements.MoveRight(); break;
		case Direction.LEFT: movements.MoveLeft(); break;
		}
	}
	
	public void TurnTo(Direction newDirection)
	{
		if(newDirection != this.direction.Reverse())
		{
			this.direction = newDirection;
		}
	}
}
