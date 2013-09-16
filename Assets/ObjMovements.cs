using UnityEngine;
using System.Collections;
using DirectionEnum;

public class ObjMovements {
	
	private GameObject obj;
	private BoardPoint position;
	
	public ObjMovements(GameObject obj) {
		this.obj = obj;
		this.position = new BoardPoint(0, 0);
	}
	
	public ObjMovements(GameObject obj, BoardPoint position) {
		this.obj = obj;
		this.position = position;
	}
	
	public void MoveUp() {
		position.X += 1;
		obj.transform.Translate(0, 0, 1);
	}
	
	public void MoveDown() {
		position.X -= 1;
		obj.transform.Translate(0, 0, -1);
	}
	
	public void MoveLeft() {
		position.Y -= 1;
		obj.transform.Translate(-1, 0, 0);
	}
	
	
	public void MoveRight() {
		position.Y += 1;
		obj.transform.Translate(1, 0, 0);
	}
	
	public void MoveTo(Direction direction)
	{
		switch(direction)
		{
		case Direction.UP: this.MoveUp(); break;
		case Direction.DOWN:this.MoveDown(); break;
		case Direction.RIGHT: this.MoveRight(); break;
		case Direction.LEFT: this.MoveLeft(); break;
		}
	}
}
