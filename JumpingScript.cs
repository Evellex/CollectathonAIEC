using UnityEngine;
using System.Collections;

public class JumpingScript : MonoBehaviour {
	bool canDJ = true;
	float Counter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space) && canDJ == true)
		{
			if(Counter < 2)
			{
				rigidbody.AddForce(transform.up*500*Time.deltaTime, ForceMode.Impulse);
				Counter++;
			}
			else
			canDJ = false;
		}
		
	
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Floor")
		{
			canDJ = true;
			Counter = 0;
		}
	}
}
