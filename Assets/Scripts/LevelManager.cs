using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void GoToLevel (string level) {
		Application.LoadLevel(level);
	}

	public void ExitLevel () {
		Application.Quit();
	}

	public void LoadNextLevel () {
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BrickDestroyed () {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}
