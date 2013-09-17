using System;
using UnityEngine;

public class SnakeTail
{
	private GameObject gameObject;
	private BoardPoint position;
	private ObjMovements movements;
	private DirectionEnum.Direction nextStepDirection;
	
	public SnakeTail (GameObject gameObj, BoardPoint position, DirectionEnum.Direction direction)
	{
		this.gameObject = gameObj;
		this.movements = new ObjMovements(this.gameObject, position);
		this.position = position;
		this.nextStepDirection = direction;
	}
	
	public void MoveNextStep()
	{
		movements.MoveTo(this.nextStepDirection);
	}
	
	public DirectionEnum.Direction NextStepDirection
	{
		get { return this.nextStepDirection; }
		set { this.nextStepDirection = value; }
	}
}
