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
		this.tails = new List<SnakeTail>();
		SnakeTailFactory fac = new SnakeTailFactory(snakeTailPrefab);
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
			MoveSnake();
			UpdateSnakePartsReferences();
			
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

	void MoveSnake ()
	{
		this.head.MoveForward();
		foreach ( SnakeTail tail in this.tails ) {
			tail.MoveNextStep();
		}
	}
	
	void UpdateSnakePartsReferences()
	{
		int i;
		int size;
		size = this.tails.Count;
		for ( i = size - 1 ; i > 0 ; i-- )
		{
			this.tails[i].Direction = this.tails[i-1].Direction;
		}
		this.tails[0].Direction = this.head.Direction;
	}
}
