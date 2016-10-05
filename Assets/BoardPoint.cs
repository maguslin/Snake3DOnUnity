using System;

public class BoardPoint
{
	private float x;
	private float y;
	
	public BoardPoint (float x, float y)
	{
		this.x = x;
		this.y = y;
	}
	
	public BoardPoint DistanceTo(BoardPoint p)
	{
		return new BoardPoint(p.X - this.X, p.Y - this.Y);
	}
	
	public float X
	{
		get { return this.x; }
		set { this.x = value; }
	}
	
	public float Y
	{
		get { return this.y; }
		set { this.y = value; }
	}
}

