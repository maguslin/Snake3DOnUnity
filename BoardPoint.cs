using System;

public class BoardPoint
{
	private int x;
	private int y;
	
	public BoardPoint (int x, int y)
	{
		this.x = x;
		this.y = y;
	}
	
	public BoardPoint DistanceTo(BoardPoint p)
	{
		return new BoardPoint(this.X - p.X, this.Y - p.Y);
	}
	
	public int X
	{
		get { return this.x; }
		set { this.x = value; }
	}
	
	
	public int Y
	{
		get { return this.y; }
		set { this.y = value;}
	}
}

