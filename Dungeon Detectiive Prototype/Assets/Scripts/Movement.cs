using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Update ()
	{
		Ray zray = new Ray(transform.position, transform.forward);

		Debug.DrawRay(transform.position, transform.forward, Color.red);
		if (Physics.Raycast(zray, 4) == false)
		{
			if (Input.GetKeyDown("w"))
			{
				transform.Translate(Vector3.forward *4);
			}
		}
		if (Input.GetKeyDown("a"))
		{          
            transform.Rotate(0, -90, 0);
		}
		if (Input.GetKeyDown("d"))
		{
			transform.Rotate(0,90,0);
		} 
	}
}