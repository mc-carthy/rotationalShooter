using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;

	private void Start () {
		moveSpeed = 0.5f;
	}

	private void Update () {
		transform.position = Vector3.Lerp (transform.position, Vector3.zero, moveSpeed * Time.deltaTime);
	}
}
