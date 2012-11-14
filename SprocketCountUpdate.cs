using UnityEngine;
using System.Collections;

public class SprocketCountUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//displays the number of collected sprockts, changes to done when all are collected
		if (CollectingManager.sprocketsCollected == CollectingManager.sprocketsToCollect)
		{
			GetComponent<TextMesh>().text =(" Done!");
		}
		else
		{
			GetComponent<TextMesh>().text =(" = " +CollectingManager.sprocketsCollected);
		}
	
	}
}
