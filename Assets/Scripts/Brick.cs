using UnityEngine;
using System.Collections;


public class Brick : MonoBehaviour {

	public int maxHits;
	public static int breakableCount = 0;

	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "breakable");

		// keep track of breakable bricks
		if (isBreakable) {
			breakableCount++;
		}

		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnCollisionEnter2D (Collision2D collision) {
		bool isBreakable = (this.tag == "breakable");
		if (isBreakable) {
			HandleHits();
		}
	}

	void HandleHits () {
		timesHit += 1;
		if (timesHit >= maxHits) {
			breakableCount--;
			print(breakableCount);
			levelManager.BrickDestroyed();
			Destroy(gameObject);
		}
	}
}
