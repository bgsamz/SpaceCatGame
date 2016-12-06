using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {
	public float speed = 0.1f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed, 0, 0);
	}
}
