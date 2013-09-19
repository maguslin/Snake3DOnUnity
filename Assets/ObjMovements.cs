using UnityEngine;
using System.Collections.Generic;
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
		RotateTo(Direction.UP);
		position.Y += 1;
		TranslateFront();
	}
	
	public void MoveDown() {
		RotateTo(Direction.DOWN);
		position.Y -= 1;
		TranslateFront();
	}
	
	public void MoveLeft() {
		RotateTo(Direction.LEFT);
		position.X -= 1;
		TranslateFront();
	}
	
	
	public void MoveRight() {
		RotateTo(Direction.RIGHT);
		position.X += 1;
		TranslateFront();
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
		RotateTo(Direction.UP);
		position.X += x;
		position.Y += y;
		this.transform.Translate(x, 0, y);
	}
	
	void RotateTo(Direction direction)
	{
		int angle;
		
		switch(direction)
		{
		case Direction.UP: angle = 0; break;
		case Direction.RIGHT: angle = 90; break;
		case Direction.DOWN: angle = 180; break;
		case Direction.LEFT: angle = 270; break;
		default: angle = 0; break;
		}
		
		transform.Rotate(0, angle - transform.rotation.eulerAngles.y, 0);
	}

	void TranslateFront ()
	{
		this.transform.Translate(0, 0, 1);
	}
}
