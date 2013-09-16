using UnityEngine;
using System.Collections;

public class ObjMovements {
	
	private GameObject obj;
	
	public ObjMovements(GameObject obj) {
		this.obj = obj;
	}
	
	public void MoveUp() {
		obj.transform.Translate(0, 0, 1);
	}
	
	public void MoveDown() {
		obj.transform.Translate(0, 0, -1);
	}
	
	public void MoveLeft() {
		obj.transform.Translate(-1, 0, 0);
	}
	
	
	public void MoveRight() {
		obj.transform.Translate(1, 0, 0);
	}
}
