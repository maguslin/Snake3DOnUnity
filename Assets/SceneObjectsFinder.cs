using System;
using UnityEngine;	

public class SceneObjectsFinder
{
	public SnakeHead SnakeHead()
	{
		GameObject headObj = GameObject.Find("SnakeHead");
		
		return new SnakeHead(headObj);
	}
	
	public SnakeTailFactory SnakeTailFactory()
	{
		GameObject tailPrefab = Resources.Load("SnakeTailPrefab") as GameObject;
		return new SnakeTailFactory(tailPrefab);;
	}
}
