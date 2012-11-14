using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		CollectingManager.countingFrogs = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//if all frogs are collected, win!
		if(CollectingManager.countingFrogs == 5)
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	
	}
}
