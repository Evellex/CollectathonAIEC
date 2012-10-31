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
		if(collider.audio == true)
			collider.audio.Play();
		
		if (collider.tag == "mushroom")
		{
		mushroomsCollected++;
		collider.gameObject.GetComponentInChildren<SphereCollider>().enabled = false;
		}
		if (collider.tag =="Sprocket")
		{
			sprocketsCollected++;
			collider.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
		}
		collider.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;

		Destroy(collider.gameObject,1.0f);
	}
}
