using UnityEngine;
using System.Collections;

public class ShroomCountUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	GetComponent<TextMesh>().text =(" = " +CollectingManager.mushroomsCollected);
	}
}
