using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	int playerScore = 0;

	public void increaseScore (int amount) {
		playerScore += amount;
	}
		
	void OnGUI () {
		GUI.Label (new Rect (10, 10, 100, 30), "Score: " + playerScore);
	}

	void OnDisable () {
		PlayerPrefs.SetInt ("Score", playerScore);
	}
}
