using UnityEngine;
using System.Collections;

public class CollectingManager : MonoBehaviour {
	
	public static int mushroomsCollected;
	public static int mushroomsToCollect;
	public static int numMushrooms;
	
	public FrogUIControl frogUI;
	
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
		else if (collider.tag =="Sprocket")
		{
			sprocketsCollected++;
			collider.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
		}
		collider.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;

		Destroy(collider.gameObject,1.0f);
	}
	
	void OnCollisionEnter (Collision collision)
	{
		Debug.Log("entered collision");
		if (collision.gameObject.audio)
		{
			collision.gameObject.audio.Play();
			Debug.Log ("playing frog sound");
		}
		if (collision.gameObject.tag =="BlueFrog")
		{
			//Debug.Log("BlueFrog");
			frogUI.EnableUIFrogs("Blue");
			collision.gameObject.GetComponentInChildren<BoxCollider>().enabled= false;
			collision.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
			Destroy(collision.gameObject,1.0f);
		}
		else if (collision.gameObject.tag =="GreenFrog")
		{
			//Debug.Log("GreenFrog");
			frogUI.EnableUIFrogs("Green");
			collision.gameObject.GetComponentInChildren<BoxCollider>().enabled= false;
			collision.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
			Destroy(collision.gameObject,1.0f);
		}
		else if (collision.gameObject.tag =="YellowFrog")
		{
			//Debug.Log("YellowFrog");
			frogUI.EnableUIFrogs("Yellow");
			collision.gameObject.GetComponentInChildren<BoxCollider>().enabled= false;
			collision.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
			Destroy(collision.gameObject,1.0f);
			
		}
		else if (collision.gameObject.tag =="RedFrog")
		{
			//Debug.Log("RedFrog");
			frogUI.EnableUIFrogs("Red");
			collision.gameObject.GetComponentInChildren<BoxCollider>().enabled= false;
			collision.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
			Destroy(collision.gameObject,1.0f);
		}
		else if (collision.gameObject.tag =="PinkFrog")
		{
			//Debug.Log("PinkFrog");
			frogUI.EnableUIFrogs("Pink");
			collision.gameObject.GetComponentInChildren<BoxCollider>().enabled= false;
			collision.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
			Destroy(collision.gameObject,1.0f);
		}
	}
}
