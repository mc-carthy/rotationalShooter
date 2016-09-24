using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed = 15f;

	private void Update () {
		transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
	}
}
