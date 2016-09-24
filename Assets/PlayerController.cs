using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {



	private void Update () {
		RotateToMousePos ();
	}

	private void RotateToMousePos () {
		Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float angle = AngleBetweenPoints (transform.position, mouseWorldPos);
		transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle + 90));
	}

	private float AngleBetweenPoints (Vector2 a, Vector2 b) {
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg; 
	}
}
