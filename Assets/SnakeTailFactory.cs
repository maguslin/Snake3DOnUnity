using UnityEngine;
using System.Collections;

public class SnakeTailFactory {
	private GameObject prefab;
	
	public SnakeTailFactory(GameObject prefab)
	{
		this.prefab = prefab;
	}
	
	public SnakeTail Build(int x, int y, BoardPoint target)
	{
		GameObject obj = GameObject.Instantiate(prefab) as GameObject;
		BoardPoint pos = new BoardPoint(x, y);
		return new SnakeTail(obj, pos, target);
	}
}
