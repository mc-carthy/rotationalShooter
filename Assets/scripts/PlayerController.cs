using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private GameObject projectile;

	private void Update () {
		RotateToMousePos ();
		FireOnMouseClick ();
	}

	private void OnTriggerEnter2D (Collider2D trig) {
		if (trig.tag == "enemy") {
			ReloadScene ();
		}
	}

	private void RotateToMousePos () {
		Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float angle = AngleBetweenPoints (transform.position, mouseWorldPos);
		transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle + 90));
	}

	private float AngleBetweenPoints (Vector2 a, Vector2 b) {
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg; 
	}

	private void FireOnMouseClick () {
		if (Input.GetMouseButtonDown (0)) {
			InstantiateProjectile ();
		}
	}

	private void InstantiateProjectile () {
		Instantiate (
			projectile,
			transform.position,
			transform.rotation
		);
	}

	private void ReloadScene() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name, LoadSceneMode.Single);
	}
}
