using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	// Use this for initialization
	public Vector2 velocidade;
	void Start () {
		Rigidbody2D rigibody = GetComponent<Rigidbody2D>();
		GetComponent<Rigidbody2D>().AddForce(velocidade);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
