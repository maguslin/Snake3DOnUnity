using System;
using UnityEngine;	

public class SnakeFactory
{
	public Snake BuildFromUnityObjs(GameObject headObj, GameObject tailPrefab)
	{
		SnakeHead head = new SnakeHead(headObj);
		SnakeTailFactory tailFactory = new SnakeTailFactory(tailPrefab);
		return new Snake(head, tailFactory);
	}
}
