/* This script will destroy the game object after X amount of seconds */

using UnityEngine;
using System.Collections;

public class DestroyGameobject : MonoBehaviour {
	
	void Start () {

		Destroy (gameObject, 13);
	
	}
}
