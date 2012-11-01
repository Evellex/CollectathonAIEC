using UnityEngine;
using System.Collections;

public class FrogUIControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		foreach(MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
		{
			mr.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void EnableUIFrogs (string colour)
	{
		//Debug.Log("Entering FrogUIControl");
	foreach (MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
		{
			//Debug.Log(child.name);
			if (mr.transform.parent.gameObject.name.Contains(colour))
			{
				mr.enabled = true;
			}
		}
	}
}
