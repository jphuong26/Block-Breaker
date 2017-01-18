using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnCollisionEnter2D (Collision2D collision){
		print("Collide");
	}

	void OnTriggerEnter2D (Collider2D collider) {
		print("Trigger");
		levelManager.GoToLevel("Lose Screen");
	}
}
