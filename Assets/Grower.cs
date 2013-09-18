using System;
using UnityEngine;

public class Grower
{
	private ObjMovements movs;
	private BoardPoint position;
	
	public Grower (GameObject obj)
	{
		BoardPointFactory pointFac = new BoardPointFactory();
		this.position = pointFac.FromGameObjPosition(obj);
		this.movs = new ObjMovements(obj, this.position);
	}
	
	public void GoToRandomly()
	{
		System.Random rand = new System.Random();
		int newX = rand.Next(15);
		int newY = rand.Next(15);
		this.movs.GoTo(newX, newY);
	}
}

