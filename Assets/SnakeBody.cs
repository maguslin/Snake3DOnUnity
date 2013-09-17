using System;
using System.Collections.Generic;

public class SnakeBody
{
	private SnakeHead head;
	private List<SnakeTail> tails;
	private List<SnakePiece> pieces;
	
	public SnakeBody (SnakeHead head)
	{
		this.head = head;
		this.tails = new List<SnakeTail>();
		this.pieces = new List<SnakePiece>();
		this.pieces.Add( head );
	}
	
	public void AddTail(SnakeTail tail)
	{
		tails.Add(tail);
		pieces.Add(tail);
	}
	
	public SnakeHead Head
	{
		get { return this.head; }
	}
	
	public List<SnakeTail> Tails
	{
		get { return this.tails; }
	}
	
	public List<SnakePiece> Pieces
	{
		get { return this.pieces; }
	}
}