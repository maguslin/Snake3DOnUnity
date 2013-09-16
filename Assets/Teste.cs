using UnityEngine;
using System.Collections;

public class Teste : MonoBehaviour {

	delegate void Transformation(float x, float y, float z);
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Transformation translate = gameObject.transform.Translate;
		Transformation rotate = gameObject.transform.Rotate;
		
		if(Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl))
		{
			checkDirectionals(rotate, 15);
		}
		else
		{
			checkDirectionals(translate, 1);
		}
			
	}
	
	void checkDirectionals(Transformation transform, int amount)
	{
		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				transform(0, 0, amount);
			}
			else if(Input.GetKeyDown(KeyCode.DownArrow))
			{
				transform(0, 0, -amount);
			}
		}
		else if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform(0, amount, 0);
		}
		else if(Input.GetKeyDown (KeyCode.LeftArrow))
		{
			transform(-amount, 0, 0);
		}
		else if(Input.GetKeyDown (KeyCode.RightArrow))
		{
			transform(amount, 0, 0);
		}
		else if(Input.GetKeyDown (KeyCode.DownArrow))
		{
			transform(0, -amount, 0);
		}
	}
}
