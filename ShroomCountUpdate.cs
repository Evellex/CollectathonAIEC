using UnityEngine;
using System.Collections;

public class ShroomCountUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//displaying the number of collected mushrooms, changes to done when all collected
		if(CollectingManager.mushroomsCollected == CollectingManager.numMushrooms)
		{
			GetComponent<TextMesh>().text =("DONE!");
		}
		else
		{
			GetComponent<TextMesh>().text =(" = " +CollectingManager.mushroomsCollected);
		}
	}
}
