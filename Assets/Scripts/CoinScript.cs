using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {
	HUDScript hud;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript> ();
			hud.increaseScore (1);
			Destroy (this.gameObject);
		}
	}
}