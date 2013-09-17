using UnityEngine;
using System.Collections;

public class SnakeTailFactory {
	private GameObject prefab;
	
	public SnakeTailFactory(GameObject prefab)
	{
		this.prefab = prefab;
	}
	
	public SnakeTail Build(int x, int y, DirectionEnum.Direction direction)
	{
		GameObject obj = GameObject.Instantiate(prefab) as GameObject;
		BoardPoint pos = new BoardPoint(0 , 0);
		ObjMovements movs = new ObjMovements(obj, pos);
		movs.GoTo(x, y);
		return new SnakeTail(obj, direction);
	}
}
