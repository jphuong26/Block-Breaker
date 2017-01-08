using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void GoToLevel (string level) {
		Application.LoadLevel(level);
	}

	public void ExitLevel () {
		Application.Quit();
	}
}
