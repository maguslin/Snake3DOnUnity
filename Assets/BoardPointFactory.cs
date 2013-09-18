using System;
using UnityEngine;

public class BoardPointFactory
{
	public BoardPoint FromGameObjPosition(GameObject obj)
	{
		int x = Convert.ToInt32(obj.transform.position.x);
		int z = Convert.ToInt32(obj.transform.position.z);
		return new BoardPoint(x, z);
	}
}