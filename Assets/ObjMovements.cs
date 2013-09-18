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
		position.Y += 1;
		this.Move(0, 1);
	}
	
	public void MoveDown() {
		position.Y -= 1;
		this.Move (0, -1);
	}
	
	public void MoveLeft() {
		position.X -= 1;
		this.Move (-1, 0);
	}
	
	
	public void MoveRight() {
		position.X += 1;
		this.Move(1, 0);
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
	
	public void Move(int x, int y)
	{
		position.X += x;
		position.Y += y;
		obj.transform.Translate(x, 0, y);
	}
	
	public void GoTo(int x, int y)
	{
		int DeltaX = x - position.X;
		int DeltaY = y - position.Y;
		this.Move(DeltaX, DeltaY);
	}
	
	
}
