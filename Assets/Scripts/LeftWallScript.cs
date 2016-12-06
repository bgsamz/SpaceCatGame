using UnityEngine;
using System.Collections;

public class LeftWallScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag != "Player") {
			Physics2D.IgnoreCollision (this.gameObject.GetComponent<Collider2D>(), other.collider);
		}
	}
}
