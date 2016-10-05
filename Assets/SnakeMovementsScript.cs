using UnityEngine;
using System.Collections;
using DirectionEnum;
using System.Collections.Generic;

public class SnakeMovementsScript : MonoBehaviour {
	private float deltaTime;
	private Snake snake;
	void Start()
	{
		this.snake = Snake.Instance();
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
		if(Input.GetKeyDown(KeyCode.UpArrow) ||Input.GetKeyDown(KeyCode.W))
		{
			this.snake.TurnTo(Direction.UP);
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.S))
		{
			this.snake.TurnTo(Direction.DOWN);
		}
		else if(Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A))
		{
			this.snake.TurnTo(Direction.LEFT);
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D))
		{
			this.snake.TurnTo(Direction.RIGHT);
		}
	}
}
