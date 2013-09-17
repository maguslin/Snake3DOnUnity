using UnityEngine;
using System.Collections;
using DirectionEnum;
using System.Collections.Generic;

public class SnakeScript : MonoBehaviour {
	private float deltaTime;
	private Snake snake;
	public GameObject snakeTailPrefab;
	
	void Start()
	{
		SnakeFactory fac = new SnakeFactory();
		this.snake = fac.BuildFromUnityObjs(gameObject, snakeTailPrefab);
		this.deltaTime = 0;
	}
	// Update is called once per frame
	void Update ()
	{
		CheckKeys ();
		
		this.deltaTime += Time.deltaTime;
		if (deltaTime > 0.075) {
			snake.MoveStepForward();
			
			this.deltaTime = 0;
		}
	}

	void CheckKeys ()
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			this.snake.TurnTo(Direction.UP);
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			this.snake.TurnTo(Direction.DOWN);
		}
		else if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			this.snake.TurnTo(Direction.LEFT);
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			this.snake.TurnTo(Direction.RIGHT);
		}
	}
}
