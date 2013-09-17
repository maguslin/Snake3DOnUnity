using System;
using System.Collections.Generic;
using DirectionEnum;

public class Snake
{
	private SnakeBody body;
	private SnakeTailFactory tailFactory;
	
	public Snake (SnakeHead head, SnakeTailFactory tailFactory)
	{
		this.body = new SnakeBody(head);
		this.tailFactory = tailFactory;
	}
	
	public void TurnTo(Direction direction)
	{
		this.body.Head.TurnTo(direction);
	}
	
	public void MoveStepForward()
	{
		MoveSnake();
		UpdateSnakePartsReferences();
	}
	
	public void Grow ()
	{
		BoardPoint positionLast = this.body.LastPiece().Position;
		SnakeTail newTail = tailFactory.Build(positionLast.X, positionLast.Y, Direction.NONE);
		this.body.AddTail(newTail);
	}
	
	void MoveSnake ()
	{
		foreach ( SnakePiece piece in this.body.Pieces ) {
			piece.MoveForward();
		}
	}
	
	void UpdateSnakePartsReferences()
	{
		int i;
		int size;
		
		List<SnakePiece> pieces = this.body.Pieces;
		size = pieces.Count;
		
		for ( i = size - 2 ; i >= 0 ; i-- )
		{
			pieces[i+1].TurnTo(pieces[i].Direction);
		}
	}
}
