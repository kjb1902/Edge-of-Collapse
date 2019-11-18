//This script is applied to a gameobject with collider, the gameobject will move left only.

using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {
	public int Speed=2;
	private int leftright=1;

	void Update () {
		leftright *= -1;

		transform.Translate (Vector3.left * Speed * Time.deltaTime);
		}

	}
