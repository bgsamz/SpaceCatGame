using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {
	public Transform player;
	public int ahead = 6;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + ahead, 0, -10);
	}
}