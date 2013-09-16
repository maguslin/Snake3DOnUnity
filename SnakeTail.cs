using System;
using UnityEngine;

public class SnakeTail
{
	private GameObject gameObject;
	private BoardPoint target;
	private BoardPoint position;
	private ObjMovements movements;
	
	public SnakeTail (GameObject gameObj, BoardPoint target, BoardPoint position)
	{
		this.gameObject = gameObj;
		this.movements = new ObjMovements(this.gameObject, position);
		this.target = target;
		this.position = position;
	}
	
	public void MoveFollowing()
	{
		BoardPoint distance = position.DistanceTo(target);
		
		if ( distance.X > 0 )
		{
			movements.MoveUp();
		}
		else if ( distance.X < 0 )
		{
			movements.MoveDown();
		}
		
		if ( distance.Y > 0 )
		{
			movements.MoveRight();
		}
		else if ( distance.Y < 0 )
		{
			movements.MoveLeft();
		}
	}
}
