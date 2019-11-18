/* This scroll script will make the material texture scroll and repeat. Be sure that the texture is set to repet, seamless and IS a texture and not a sprite 
 * or otherwise it will not work. Do not confuse this SCROLL script with the MoveLeft script. This script will only scroll the textures, 
 * while the other will acctually move the prefab. This is mostly used for the background, scrolling skys and grounds only. */


using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speed = 0;

	void Update () {
				
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.time*speed)%1,0f);

	}
}
