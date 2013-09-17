using System;
using UnityEngine;

public class SnakeTail
{
	private GameObject gameObject;
	private BoardPoint position;
	private ObjMovements movements;
	private DirectionEnum.Direction direction;
	
	public SnakeTail (GameObject gameObj, BoardPoint position, DirectionEnum.Direction direction)
	{
		this.gameObject = gameObj;
		this.movements = new ObjMovements(this.gameObject, position);
		this.position = position;
		this.direction = direction;
	}
	
	public void MoveNextStep()
	{
		movements.MoveTo(this.direction);
	}
	
	public DirectionEnum.Direction Direction
	{
		get { return this.direction; }
		set { this.direction = value; }
	}
}
