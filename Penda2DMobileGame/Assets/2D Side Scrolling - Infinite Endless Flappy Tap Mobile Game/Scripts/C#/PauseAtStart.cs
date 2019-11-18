//The script will pause the scene so it won't instantly start, until you press the mouse button.

using UnityEngine;
using System.Collections;

public class PauseAtStart : MonoBehaviour {
	
	public AudioClip StartSound;
	
	void Start () {
		isStartButtonPressed = false;
		Time.timeScale = 0.0f;
	}
	
	private bool isStartButtonPressed;
	//public GUIText scoreLabel;
	void OnGUI()
	{
		if (!isStartButtonPressed)
		{
			//GUI.TextField(new Rect(Screen.width/2-65, Screen.height/2-11 ,130,22), "Touch Here To Play");
			if(Input.anyKeyDown)
			{
				GetComponent<AudioSource>().PlayOneShot(StartSound, 7.7F);
				Time.timeScale = 1.0f;
				isStartButtonPressed = true;
			}
		}
	}
}