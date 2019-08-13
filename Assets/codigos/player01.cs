using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player01 : MonoBehaviour {
	// Update is called once per frame
	public float velocidade = 10.0f;
	public float horizontalAxis;
	public Rigidbody2D rigidbody;

	void Start(){
		rigidbody = GetComponent<Rigidbody2D>();
	}
	void Update () {
		horizontalAxis = Input.GetAxis ("Horizontal");
		rigidbody.velocity = new Vector2 (velocidade * horizontalAxis, 0);
	}
}
