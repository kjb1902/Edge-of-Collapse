/* This is the advanced obstacles Advanced Spawner. You can select up to 6 prefabs which you can spawn in the scene on the same position. 
 * You can also change the time of the range where the prefabs will be spawned. For example; minRange=3 to maxRange=8 is spawn a prefab from 3 to 8 seconds only.
 * Be sure that the prefabs that you are spawning have the MoveLeft/MoveRight script attached, so when it is spawned it will move otherwise it will just spawn and stay where it was spawned. */

using UnityEngine;
using System.Collections;

public class ObstacleAdvanced : MonoBehaviour {

	//The gameobject that will be spawned of your choice.
	public GameObject rotator;
	public GameObject rotator2;
	public GameObject rotator3;
	public GameObject rotator4;
	public GameObject rotator5;
	public GameObject rotator6;
	int chooser = 5;
	public int minSpawnRange=3;
	public int maxSpawnRange=8;


	void Start () {
		StartCoroutine ("generateRotators");
	}
	
	IEnumerator generateRotators()
	{

		int wait_time = Random.Range (minSpawnRange, maxSpawnRange);
		//yield return new WaitForSeconds (wait_time);

		while (true) {
			yield return new WaitForSeconds (wait_time);
			GameObject tempObject = (GameObject)Instantiate (rotator,transform.position,Quaternion.identity);
			yield return new WaitForSeconds (wait_time);
			//tempObject.GetComponent<MoveLeft>().leftright = chooser;
			chooser *= -5;
			yield return new WaitForSeconds (wait_time);
			GameObject tempObject1 = (GameObject)Instantiate (rotator2,transform.position,Quaternion.identity);
			yield return new WaitForSeconds (wait_time);
			GameObject tempObject2 = (GameObject)Instantiate (rotator3,transform.position,Quaternion.identity);
			yield return new WaitForSeconds (wait_time);
			GameObject tempObject3 = (GameObject)Instantiate (rotator4,transform.position,Quaternion.identity);
			yield return new WaitForSeconds (wait_time);
			GameObject tempObject4 = (GameObject)Instantiate (rotator5,transform.position,Quaternion.identity);
			yield return new WaitForSeconds (wait_time);
			GameObject tempObject5 = (GameObject)Instantiate (rotator6,transform.position,Quaternion.identity);
			yield return new WaitForSeconds (wait_time);

		}
		
	}

	void OnGUI () 
	{
		GUI.color = Color.black;
	}

	void Update () {
		
	}
}
