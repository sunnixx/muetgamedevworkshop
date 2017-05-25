using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	public Vector2 velocity = new Vector2 (-4, 0);
	public Rigidbody2D pillars;
	public float range = 4;

	// Use this for initialization
	void Start () {
		pillars.velocity = velocity;
		transform.position = new Vector3 (transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
