/* This is the simple obstacles simple spawner. You can only select 1 prefab which you can spawn in the scene.
This will only spawn the prefab, but be sure that the prefab will have 2 gameobject sides (up and bottom) such example; as a pipe.
Be sure that the prefabs that you are spawning (example: pipe pair) have the Move Left Pair Rigidbody script attached, so when it is spawned it will move and also go up and down. */

using UnityEngine;

public class ObstacleSimple : MonoBehaviour {

	public GameObject gameobjectPair;
	public float SpawnRange=2.5f;

	void Start()
	{
		InvokeRepeating("CreateObstacle", 2.5f, SpawnRange);
	}
	
	void CreateObstacle()
	{
		Instantiate(gameobjectPair);
	}
}