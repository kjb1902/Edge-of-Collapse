using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour {

	public Texture2D Crosshair;
	public int CrosshairSizeX = 65; 
	public int CrosshairSizeY = 55;

	void  Start (){
		Cursor.visible = false;
	}

	void  OnGUI (){
		GUI.DrawTexture ( new Rect(Event.current.mousePosition.x-CrosshairSizeX/2, Event.current.mousePosition.y-CrosshairSizeY/2, CrosshairSizeX, CrosshairSizeY), Crosshair);
	}
}
