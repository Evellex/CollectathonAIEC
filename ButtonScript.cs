using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	
	bool buttonActivated = false;
	public GameObject attatchedObject;
	
	// Use this for initialization
	void Start () {
		attatchedObject.GetComponent<MeshRenderer>().enabled = false;
		attatchedObject.GetComponent<BoxCollider>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(buttonActivated == true)
		{
			attatchedObject.GetComponent<MeshRenderer>().enabled = true;
			attatchedObject.GetComponent<BoxCollider>().enabled = true;
		}
	}
	void OnCollisionEnter(Collision collision)
	{
		animation.Play();
		buttonActivated = true;
	}
}
