using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	
	public GameObject attatchedObject;
	
	// Use this for initialization
	void Start () {
		if (attatchedObject.GetComponent<MeshRenderer>())
		{
		attatchedObject.GetComponent<MeshRenderer>().enabled = false;
		}
		else
		{
			attatchedObject.GetComponentInChildren<MeshRenderer>().enabled = false;
		}
		attatchedObject.GetComponent<BoxCollider>().enabled = false;
		attatchedObject.rigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision)
	{
		if (attatchedObject)
		{
		//animation.Play();
		if (attatchedObject.GetComponent<MeshRenderer>())
		{
		attatchedObject.GetComponent<MeshRenderer>().enabled = true;
		}
		else
		{
			attatchedObject.GetComponentInChildren<MeshRenderer>().enabled = true;
		}
		attatchedObject.GetComponent<BoxCollider>().enabled = true;
		attatchedObject.rigidbody.isKinematic = false;
		}
	}
}
