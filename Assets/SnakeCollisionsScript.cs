using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SnakeCollisionsScript : MonoBehaviour {
	private Snake snake;
	public Image gameover;
	void Start () {
		this.snake = Snake.Instance();
		gameover.gameObject.SetActive(false);
	}
	
	void OnTriggerEnter  (Collider collision)
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
		gameover.gameObject.SetActive(true);
		//UnityEditor.EditorApplication.isPlaying = false;
	}
}
