using UnityEngine;
using System.Collections;
using DirectionEnum;

public class ObjMovements {
	
	private Transform transform;
	private BoardPoint position;
	
	public ObjMovements(Transform transform) {
		this.transform = transform;
		this.position = new BoardPoint(0, 0);
	}
	
	public ObjMovements(Transform transform, BoardPoint position) {
		this.transform = transform;
		this.position = position;
	}
	
	public void MoveUp() {
		this.Move(0, 1);
	}
	
	public void MoveDown() {
		this.Move (0, -1);
	}
	
	public void MoveLeft() {
		this.Move (-1, 0);
	}
	
	
	public void MoveRight() {
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
	
	public void GoTo(int x, int y)
	{
		int DeltaX = x - position.X;
		int DeltaY = y - position.Y;
		this.Move(DeltaX, DeltaY);
	}
	
	public void Move(int x, int y)
	{
		position.X += x;
		position.Y += y;
		this.transform.Translate(x, 0, y);
	}
	
}
