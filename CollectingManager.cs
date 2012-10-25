using UnityEngine;
using System.Collections;

public class CollectingManager : MonoBehaviour {
	
	public static int mushroomsCollected;
	public static int mushroomsToCollect;
	
	public static int sprocketsToCollect, sprocketsCollected;
	
	
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
		if (collider.tag =="Sprocket")
		{
			Destroy(collider.gameObject);
			sprocketsCollected++;
		}
	}
}
