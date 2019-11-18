using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Just in case the camera stops because of timer, reset timer for menu.
	void Start () {

		if (Time.timeScale == 0.0F)
			Time.timeScale = 1.0F;
		else
			Time.timeScale = 1.0F;
		Time.fixedDeltaTime = 0.02F * Time.timeScale;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
