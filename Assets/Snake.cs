using UnityEngine;
using System.Collections;
using DirectionEnum;

public class Snake : MonoBehaviour {
	private float deltaTime;
	private SnakeHead head;
	public GameObject snakeTailPrefab;
	private SnakeTail tail;
	
	void Start()
	{
		this.head = new SnakeHead(gameObject);
		this.deltaTime = 0;
		SnakeTailFactory fac = new SnakeTailFactory(snakeTailPrefab);
		this.tail = fac.Build(1, 0, head.Position);
	}
	// Update is called once per frame
	void Update ()
	{
		CheckKeys ();
		
		this.deltaTime += Time.deltaTime;
		if (deltaTime > 0.5) {
			//MoveObjects ();
			this.deltaTime = 0;
		}
	}

	void CheckKeys ()
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
	}

	void MoveObjects ()
	{
		this.tail.MoveNextStep();
		this.tail.NextStepDirection = this.head.Direction;
		this.head.MoveForward();
	}
}
