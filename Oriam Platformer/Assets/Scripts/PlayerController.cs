using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject {

	public float maxSpeed = 7;
	public float jumpSpeed = 7;

	void Awake() {
		GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
		camera.GetComponent<CameraFollow>().SetTarget(transform);
	}

	protected override void ComputeVelocity() {
		Vector2 move = Vector2.zero;

		move.x = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown("Jump") && grounded) {
			velocity.y = jumpSpeed;
		}
		else if (Input.GetButtonUp("Jump")) {
			if (velocity.y > 0) {
				velocity.y = velocity.y * 0.5f;
			}
		}
		targetVelocity = move * maxSpeed;

	}

	/*(public float moveSpeed;
	private Rigidbody2D body;
	private InputState input;

	// Use this for initialization
	void Awake () {
		input = GetComponent<InputState> ();
		body = GetComponent<Rigidbody2D> ();
		moveSpeed = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		if (input.leftButton) {
			body.position.x -= moveSpeed;
		}

		if (input.rightButton) {	
			body.position.y += moveSpeed;
		}

		if (input.upButton) {
			body.position.y += moveSpeed;
		}

	}*/
}
