using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int number = 10;
		print ("The number is " + number);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up Arrow was pressed");
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			print ("Space key was pressed");
		}
	}
}








