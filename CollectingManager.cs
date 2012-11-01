using UnityEngine;
using System.Collections;

public class CollectingManager : MonoBehaviour {
	
	public static int mushroomsCollected;
	public static int mushroomsToCollect;
	
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
		if (collision.gameObject.tag =="BlueFrog")
		{
			//Debug.Log("BlueFrog");
			frogUI.EnableUIFrogs("Blue");
			Destroy(collision.gameObject);
		}
		else if (collision.gameObject.tag =="GreenFrog")
		{
			//Debug.Log("GreenFrog");
			frogUI.EnableUIFrogs("Green");
			Destroy(collision.gameObject);
		}
		else if (collision.gameObject.tag =="YellowFrog")
		{
			//Debug.Log("YellowFrog");
			frogUI.EnableUIFrogs("Yellow");
			Destroy(collision.gameObject);
			
		}
		else if (collision.gameObject.tag =="RedFrog")
		{
			//Debug.Log("RedFrog");
			frogUI.EnableUIFrogs("Red");
			Destroy(collision.gameObject);
		}
		else if (collision.gameObject.tag =="PinkFrog")
		{
			//Debug.Log("PinkFrog");
			frogUI.EnableUIFrogs("Pink");
			Destroy(collision.gameObject);
		}
	}
}
