using System;
using DirectionEnum;
using UnityEngine;

public class SnakeTail : SnakePiece
{
	private GameObject gameObject;
	private BoardPoint position;
	private ObjMovements movements;
	private Direction direction;
	
	public SnakeTail (GameObject gameObj, BoardPoint position, DirectionEnum.Direction direction)
	{
		this.gameObject = gameObj;
		this.movements = new ObjMovements(this.gameObject, position);
		this.position = position;
		this.direction = direction;
	}
	
	public void MoveForward()
	{
		movements.MoveTo(this.direction);
	}
	
	public void TurnTo(Direction newDirection)
	{
		if(newDirection != this.direction.Reverse())
		{
			this.direction = newDirection;
		}
	}
	
	public Direction Direction
	{
		get { return this.direction; }
	}
}
