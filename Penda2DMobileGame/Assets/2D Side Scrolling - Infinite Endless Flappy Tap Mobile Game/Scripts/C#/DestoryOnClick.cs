//Simple script where when the player presses the mouse button, the gameobject is destroyed.

using UnityEngine;
using System.Collections;

public class DestoryOnClick : MonoBehaviour {
	
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{
			Destroy (gameObject);
	}
  }
}
