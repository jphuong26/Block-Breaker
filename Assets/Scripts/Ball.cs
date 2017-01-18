using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private Rigidbody2D myRigidBody;

	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			// Lock ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;

			// Launches ball if mouse is clicked
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse button clicked");
				hasStarted = true;
				this.myRigidBody.velocity = new Vector2 (2f, 10f);
			}
		}
	}
}
