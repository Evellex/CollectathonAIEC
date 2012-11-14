using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	
	public static bool startedGame = false;
	public static bool djMode = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 100, 50), "Start Game"))
		{
			startedGame = true;
		}
		else if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 4 * 3, 100, 50), "dj Mode"))
		{
			djMode = !djMode;
		}
		if (djMode == true)
		{
			GUI.Label(new Rect(10, 10 / 2, 50, 100), "dj Mode enabled");
		}
	}
}
