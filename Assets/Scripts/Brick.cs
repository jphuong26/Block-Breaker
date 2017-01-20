using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	
	}

	void OnCollisionEnter2D (Collision2D collision) {
		timesHit = timesHit + 1;
		if (timesHit >= maxHits) {
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
