using UnityEngine;
using System.Collections;

public class SnakeTailFactory {
	private GameObject prefab;
	
	public SnakeTailFactory(GameObject prefab)
	{
		this.prefab = prefab;
	}
	
	public SnakeTail Build(float x, float y, DirectionEnum.Direction direction)
	{
		GameObject obj = GameObject.Instantiate(prefab) as GameObject;
		BoardPoint pos = new BoardPoint(0 , 0);
		ObjMovements movs = new ObjMovements(obj.transform, pos);
		movs.GoTo(x, y);
		return new SnakeTail(obj, pos, direction);
	}
}
