using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	int score = 0;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}

	void OnGUI () {
		GUI.Label (new Rect (Screen.width / 2 - 50, 50, 100, 100), "GAME OVER");
		GUI.Label (new Rect (Screen.width / 2 - 50, 300, 100, 100), "Score: " + score);
		if (GUI.Button (new Rect (Screen.width / 2 - 50, 450, 100, 50), "Play Again?")) {
			SceneManager.LoadScene (0, LoadSceneMode.Single);
		}
	}
}
