using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	public Vector2 jumpForce = new Vector2(0,300);
	public Rigidbody2D rigid;

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigid.velocity = Vector2.zero;
			rigid.AddForce (jumpForce);
		}
	}

	void OnCollisionEnter2D(){
		print ("Collision");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	/*
	public Vector2 jumpForce = new Vector2 (0, 300);
	public Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigid.velocity = Vector2.zero;
			rigid.AddForce (jumpForce);
		}
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			Die ();
		}
	}

	//Die By Collision
	void OnCollisionEnter2D(Collision2D other){
		Die ();
	}

	void Die(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}*/
}
