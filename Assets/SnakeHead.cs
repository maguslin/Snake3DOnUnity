using UnityEngine;
using System.Collections;
using DirectionEnum;
using System;

public class SnakeHead : SnakePiece
{
	private ObjMovements movements;
	private Direction direction;
	private GameObject gameObject;
	private BoardPoint position;
	
	public SnakeHead (GameObject gameObject)
	{
		int x = Convert.ToInt32(gameObject.transform.position.x);
		int z = Convert.ToInt32(gameObject.transform.position.z);
		this.position = new BoardPoint(x, z);
		this.gameObject = gameObject;
		this.direction = Direction.UP;
		this.movements = new ObjMovements(this.gameObject, this.position);
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
	
	public BoardPoint Position
	{
		get { return this.position; }
	}
	
	public Direction Direction
	{
		get { return this.direction; }
	}
}
