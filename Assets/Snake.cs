using UnityEngine;
using System.Collections;
using DirectionEnum;
using System.Collections.Generic;

public class Snake : MonoBehaviour {
	private float deltaTime;
	private SnakeHead head;
	public GameObject snakeTailPrefab;
	private List<SnakeTail> tails;
	
	void Start()
	{
		this.head = new SnakeHead(gameObject);
		this.deltaTime = 0;
		SnakeTailFactory fac = new SnakeTailFactory(snakeTailPrefab);
		this.tails = new List<SnakeTail>();
		this.tails.Add(fac.Build(0, 4, Direction.UP));
		this.tails.Add(fac.Build(0, 3, Direction.UP));
		this.tails.Add(fac.Build(0, 2, Direction.UP));
		this.tails.Add(fac.Build(0, 1, Direction.UP));
		this.tails.Add(fac.Build(0, 0, Direction.UP));
	}
	// Update is called once per frame
	void Update ()
	{
		CheckKeys ();
		
		this.deltaTime += Time.deltaTime;
		if (deltaTime > 0.075) {
			MoveObjects ();
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
		int i;
		int size;
		
		this.head.MoveForward();
		foreach ( SnakeTail tail in this.tails ) {
			tail.MoveNextStep();
		}
		
		size = this.tails.Count;
		for ( i = size - 1 ; i > 0 ; i-- )
		{
			this.tails[i].NextStepDirection = this.tails[i-1].NextStepDirection;
		}
		
		this.tails[0].NextStepDirection = this.head.Direction;
		size = this.tails.Count;
	}
}
