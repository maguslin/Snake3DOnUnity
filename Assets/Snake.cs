using UnityEngine;
using System.Collections;
using DirectionEnum;

public class Snake : MonoBehaviour {
	private float deltaTime;
	private SnakeHead head;
	
	void Start()
	{
		this.head = new SnakeHead(gameObject);
		this.deltaTime = 0;
	}
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			this.head.TurnTo(Direction.UP);
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			this.head.TurnTo(Direction.DOWN);
		}
		else if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			this.head.TurnTo(Direction.LEFT);
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			this.head.TurnTo(Direction.RIGHT);
		}
		this.deltaTime += Time.deltaTime;
		if (deltaTime > 0.075) {
			this.head.MoveForward();
			this.deltaTime = 0;
		}
	}
}
