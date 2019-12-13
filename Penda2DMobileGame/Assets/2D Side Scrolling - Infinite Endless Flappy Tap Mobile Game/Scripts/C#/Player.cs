//This is the player script where the player will jump with a force of your choice when you click on the screen.
//You can also set the hud displays, the game end hud and the end game sound.

using UnityEngine;

public class Player : MonoBehaviour
{
	public Vector2 jumpForce = new Vector2(0, 300); //jumping force which can be changed in the inspector.
	bool showGUI1 = false; 	//The GUI won't be shown until it is triggerd.
	public Texture EndgameHudBackground; 	//The HUDs that will be displayed when the game ends (1).
	public Texture EndgameHudForeground; //The HUDs that will be displayed when the game ends (2).
	bool showGUI = true; //The GUI will be shown.
	public AudioClip DeathSound; //The audio that will play when the game ends.
	//public AudioClip JumpSound; //Sound will play when ever the player jumps.
	public static int score; //The score distance of the player.
	//float startTime; //Start timer.
	float m_Timer = 2.0f; //How much time will pass till you get an increase in the score distance. 2.0f for 2 seconds.
	public GUIStyle DisplayScore = new GUIStyle(); //The GUI that will be displayed when the game ends onscreen.
	public GUIStyle ScreenScore = new GUIStyle(); //The GUI that will be displayed always on screen.

	void Start () {
		score = 0; //Score always starts at 0.
				   //startTime = Time.time;
				   //isStartButtonPressed = false;
			       //Time.timeScale = 0.0f;
	}

	void Update ()
	{

		m_Timer -= Time.deltaTime;
		if(m_Timer <= 0.0f)
			
		{
			score++;
			m_Timer = 3.0f;
		}
		if (Input.GetMouseButtonDown(0)) //if mouse button is cliked then jump, you can use (Input.GetKeyUp("space")) instead for space.
		{
			//GetComponent<AudioSource>().PlayOneShot(JumpSound, 7.7F); //Use this to play a audio when jump.
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
	}
	private bool isStartButtonPressed;

	void OnGUI()
	{
		if (showGUI)
		{
			GUI.Label (new Rect (17, 17, 110, 110), "<b>Distance Travelled:</b> " +score + "", ScreenScore);
		}

		if (showGUI1)
		{
			//The GUI that will be displayed when the game ends onscreen and onclick; the player will return to menu.
			GUI.DrawTexture(new Rect(((Screen.width / 10) - 999f), ((Screen.height / 30) - 1281.5f), 4190, 4125), EndgameHudBackground, ScaleMode.ScaleToFit, true, 0.0F);
			GUI.DrawTexture(new Rect(((Screen.width / 6) - 135f), ((Screen.height / 3) - 330f), 750, 762), EndgameHudForeground, ScaleMode.ScaleToFit, true, 0.0F);
			//DisplayScore.normal.textColor = Color.white;
			//guiStyle.alignment = TextAnchor.MiddleCenter;
			GUI.Label (new Rect(Screen.width / 4 - 50f, ((Screen.height / 2) - 34.5f), 80, -105), "Final Distance " + score + "", DisplayScore);
				if (Input.GetMouseButtonDown(0)) {
					Application.LoadLevel ("Menu");
					}
				}
			}
		
	void OnCollisionEnter2D(Collision2D other)
	{
		GetComponent<AudioSource>().PlayOneShot(DeathSound, 7.7F);
		Die();
		showGUI1 = true;
	}

    void Die()
    {
        Destroy(GameObject.FindWithTag("Music"));
        showGUI1 = true;
        Time.timeScale = 0.0f;
    }
}

