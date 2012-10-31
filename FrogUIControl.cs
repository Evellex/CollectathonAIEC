using UnityEngine;
using System.Collections;

public class FrogUIControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//gameObjeGetComponentsInChildren<MeshRenderer>()
		foreach(MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
		{
			mr.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
