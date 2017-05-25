using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	public GameObject pillars;
	int score = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacles", 1f, 1.5f);
	}

	void OnGUI(){
		GUI.color = Color.black;
		GUILayout.Label ("Score: " + score.ToString ());
	}

	void CreateObstacles(){
		Instantiate (pillars);
		score++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
