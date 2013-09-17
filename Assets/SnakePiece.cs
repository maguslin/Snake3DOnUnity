using System;
using DirectionEnum;

public interface SnakePiece
{
	void MoveForward();
	
	void TurnTo(Direction newDirection);
	
	Direction Direction
	{
		get;
	}
	
	BoardPoint Position
	{
		get;
	}
	
}

