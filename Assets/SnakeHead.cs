using UnityEngine;
using System.Collections;
using DirectionEnum;
using System;
using System.Collections.Generic;

public class SnakeHead : SnakePiece
{
	private ObjMovements movements;
	private Direction direction;
	private GameObject gameObject;
	private BoardPoint position;
	private List<Direction> turns;
	
	public SnakeHead (GameObject gameObject)
	{
		BoardPointFactory pointFac = new BoardPointFactory();
		this.position = pointFac.FromGameObjPosition(gameObject);
		this.gameObject = gameObject;
		this.direction = Direction.UP;
		this.movements = new ObjMovements(this.gameObject.transform, this.position);
		this.turns = new List<Direction>();
	}
	
	public void MoveForward()
	{
		movements.MoveTo(this.direction);
	}
	
	public void UpdateDirection()
	{
		if (this.turns.Count != 0)
		{
			this.direction = this.turns[0];
			this.turns.RemoveAt(0);
		}
	}
	
	public void TurnTo(Direction newDirection)
	{
		Direction previous;
		if(this.turns.Count == 0)
		{
			previous = this.direction;
		}
		else
		{
			previous = this.turns[this.turns.Count-1];
		}
		
		if(newDirection != previous.Reverse() || newDirection == previous)
		{
			this.turns.Add(newDirection);
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
