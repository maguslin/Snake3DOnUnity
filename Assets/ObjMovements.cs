using UnityEngine;
using System.Collections;

public class ObjMovements {
	
	private GameObject obj;
	private BoardPoint position;
	
	public ObjMovements(GameObject obj) {
		this.obj = obj;
		this.position = new BoardPoint(0, 0);
	}
	
	public ObjMovements(GameObject obj, BoardPoint position) {
		this.obj = obj;
		this.position = position;
	}
	
	public void MoveUp() {
		position.X += 1;
		obj.transform.Translate(0, 0, 1);
	}
	
	public void MoveDown() {
		position.X -= 1;
		obj.transform.Translate(0, 0, -1);
	}
	
	public void MoveLeft() {
		position.Y -= 1;
		obj.transform.Translate(-1, 0, 0);
	}
	
	
	public void MoveRight() {
		position.Y += 1;
		obj.transform.Translate(1, 0, 0);
	}
}
