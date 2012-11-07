using UnityEngine;
using System.Collections;

public class JumpingScript : MonoBehaviour {
	bool canDJ = true;
	float Counter = 0;
	bool canSJ = true;
	float Timer = 0;
	
	bool startTimer = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (rigidbody.velocity.magnitude < 10)
		{
			if(Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.LeftControl) && canSJ == true)
			{
				rigidbody.AddForce(transform.up*1200*Time.deltaTime, ForceMode.Impulse);
				canDJ = false;
				canSJ = false;
			}
		}
		
		if(Input.GetKeyDown(KeyCode.Space) && canDJ == true)
		{
			canSJ = false;
			
			if(Counter < 2)
			{
				rigidbody.AddForce(transform.up*400*Time.deltaTime, ForceMode.Impulse);
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
			canSJ = true;
		}
	}
}
