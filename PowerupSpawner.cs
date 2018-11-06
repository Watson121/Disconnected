using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour {

	[SerializeField]
	private Vector3[] spawnLocation;
	private int numberOfSpawns = 12;
	private GameObject powerPlus, powerMinus;
	private float timeOfNextSpawn;

	void Start () {
		timeOfNextSpawn = Time.time + 10;

		spawnLocation = new Vector3[numberOfSpawns];
		spawnLocation[0] = new Vector3(-2f,-0.67f,-2.3f);
		spawnLocation[1] = new Vector3(2f,-0.67f,-2.3f);
		spawnLocation[2] = new Vector3(7f,2f,-2.3f);
		spawnLocation[3] = new Vector3(-7f,2f,-2.3f);
		spawnLocation[4] = new Vector3(-4f,3.5f,-2.3f);
		spawnLocation[5] = new Vector3(4f,3.5f,-2.3f);
		spawnLocation[6] = new Vector3(0f,3.5f,-2.3f);
		spawnLocation[7] = new Vector3(0f,0.5f,-2.3f);
		spawnLocation[8] = new Vector3(-4f,5.5f,-2.3f);
		spawnLocation[9] = new Vector3(4f,-2f,-2.3f);
		spawnLocation[10] = new Vector3(-4f,0.5f,-2.3f);
		spawnLocation[11] = new Vector3(4f,3f,-2.3f);
	}
	

	void Update () {
		preSpawn();
	}

	void preSpawn () {
		if (Time.time>timeOfNextSpawn) {
			int rand1 = Random.Range (0, 12);
			spawn (spawnLocation[rand1]);
			int rand2 = Random.Range (5, 11);  ///////////////////spawns between every 5 & 11 seconds 
			timeOfNextSpawn = Time.time + rand2;
		}
	}
		

	void spawn (Vector3 pos) {
		int rand = Random.Range (0, 2);
		if (rand == 0) {
			powerPlus = Resources.Load ("PowerUpPlus") as GameObject;
			GameObject loadedPowerUp = Instantiate (powerPlus) as GameObject;
			loadedPowerUp.transform.position = pos;
		} else {
			powerMinus = Resources.Load ("PowerUpMinus") as GameObject;
			GameObject loadedPowerUp = Instantiate (powerMinus) as GameObject;
			loadedPowerUp.transform.position = pos;
		}
	}
}
