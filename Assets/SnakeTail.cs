using System;
using UnityEngine;

public class SnakeTail
{
	private GameObject gameObject;
	private BoardPoint target;
	private BoardPoint position;
	private ObjMovements movements;
	private DirectionEnum.Direction nextStepDirection;
	
	public SnakeTail (GameObject gameObj, BoardPoint position, BoardPoint target)
	{
		this.gameObject = gameObj;
		this.movements = new ObjMovements(this.gameObject, position);
		this.target = target;
		this.position = position;
	}
	
	public void MoveNextStep()
	{
		movements.MoveTo(nextStepDirection);
	}
	
	public DirectionEnum.Direction NextStepDirection
	{
		set { this.nextStepDirection = value; }
	}
}
