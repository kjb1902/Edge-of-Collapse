/* This script is for the gameobjects that will be used for the ObstacleSpawnerSimple ONLY.
 * This script is applied to a gameobject with collider and rigidbody, the gameobject will then move left only.
 * Unlike the other script, this one have an Up and Down Position which will make the gameobject spawn higher
 * and lower, perfect for spawning pipe pair for a fast platform game that you have to evade. */


using UnityEngine;

public class MoveLeftPairRigidbody : MonoBehaviour
{
	private Vector2 velocity = new Vector2(-4, 0);
	public float UpAndDownPosition = 4;

	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - UpAndDownPosition * Random.value, transform.position.z);
	}
}