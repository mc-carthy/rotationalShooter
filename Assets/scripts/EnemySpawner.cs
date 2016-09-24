using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	[SerializeField]
	private EnemyController enemy;
	private float spawnTime = 1;
	private bool canSpawnEnemy = true;

	private void Start () {
		StartCoroutine (SpawnEnemies ());
	}

	private IEnumerator SpawnEnemies () {
		while (canSpawnEnemy) {
			yield return new WaitForSeconds (spawnTime);
			SpawnEnemy ();
		}
	}

	private void SpawnEnemy () {
		Instantiate (
			enemy,
			GenerateSpawnPositon(),
			Quaternion.identity
		);
	}

	private Vector2 GenerateSpawnPositon (float radius = 30) {
		Vector2 spawnPos = Random.insideUnitCircle.normalized * radius;
		print (spawnPos);
		return spawnPos;

	}
}
