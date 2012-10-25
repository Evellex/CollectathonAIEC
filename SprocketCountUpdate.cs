using UnityEngine;
using System.Collections;

public class SprocketCountUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	GetComponent<TextMesh>().text =(" = " +CollectingManager.sprocketsCollected);
	}
}
