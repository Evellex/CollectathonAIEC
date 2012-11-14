using UnityEngine;
using System.Collections;

public class SprocketRotation : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		//Counts how many sprockets are in the game, each instance increments the counter
		CollectingManager.sprocketsToCollect++;
	}
	
	// Update is called once per frame
	void Update () {
		//a visualy appealing spin
	transform.Rotate(transform.right, Time.deltaTime * 100.0f);
	}
}
