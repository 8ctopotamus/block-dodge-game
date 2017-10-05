using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public GameObject blockPrefab;
	public Transform[] spawnPoints;
	public float timeBetweenWaves = 1.2f;

	private float timeToSpawn = 2f;

	void Update () {
		if (Time.time >= timeToSpawn) {
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}
	}

	void SpawnBlocks () {
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++) {
			if (randomIndex != i) {
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
}
