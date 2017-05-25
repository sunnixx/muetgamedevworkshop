using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour {
	public GameObject coin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (coin);
	}
}
