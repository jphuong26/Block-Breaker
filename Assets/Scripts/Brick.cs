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
		if (isBreakable) {
			HandleHits();
		}
	}

	void HandleHits () {
		timesHit = timesHit + 1;
		if (timesHit >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
		}
	}

	// TODO remove method when win method is decided
	void SimulateWin () {
		levelManager.LoadNextLevel(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
