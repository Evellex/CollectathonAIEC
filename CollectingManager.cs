using UnityEngine;
using System.Collections;

public class CollectingManager : MonoBehaviour {
	
	int mushroomsCollected;
	public static int mushroomsToCollect;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "mushroom")
		{
		mushroomsCollected++;
		
			Destroy(collider.gameObject);
			Debug.Log("Deleting mushroom");
			audio.Play();
		}
	}
}
