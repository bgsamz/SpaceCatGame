using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FallingBlockScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			SceneManager.LoadScene(1, LoadSceneMode.Single);
		} else {
			Destroy (this.gameObject);
		}
	}
}
