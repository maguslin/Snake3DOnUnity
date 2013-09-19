using UnityEngine;
using System.Collections;

public class SnakeCollisionsScript : MonoBehaviour {
	private Snake snake;
	
	void Start () {
		this.snake = Snake.Instance();
	}
	
	void OnCollisionEnter (Collision collision)
	{
		GameObject collider = collision.gameObject;
		switch(collider.name)
		{
		case "Grower": this.snake.Grow(); break;
		case "SnakeTailPrefab(Clone)": GameOver(); break;
		}
	}
	
	void OnCollisionExit(Collision col)
	{
		GameObject collider = col.gameObject;
		if(collider.name == "field")
		{
			GameOver();
		}
	}
	
	void GameOver()
	{
		Debug.Log ("GAME OVER");
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
