using UnityEngine;
using System.Collections;

public class JumpingScript : MonoBehaviour {
	bool canDJ = true;
	float Counter = 0;
	bool canSJ = true;
	float Timer = 0;
	public static bool isTouchingGround = false;
	
	bool startTimer = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//spring jump only works if player is below a speed threshold (magic numbers are bad alex! :P)
			if (rigidbody.velocity.magnitude < 10)
			{
				if(Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.LeftControl) && canSJ == true)
				{
					playerdeath.startPosition = gameObject.transform.position;
					rigidbody.AddForce(transform.up*1200*Time.deltaTime, ForceMode.Impulse);
					canDJ = false;
					isTouchingGround = false;
					canSJ = false;
				}
			}
			//normal jumping
			if(Input.GetKeyDown(KeyCode.Space) && canDJ == true)
			{
				canSJ = false;
				
				if(Counter < 2)
				{
					rigidbody.AddForce(transform.up*400*Time.deltaTime, ForceMode.Impulse);
					Counter++;
					isTouchingGround = false;
				
					if (Counter <= 1)
					{
						playerdeath.startPosition = gameObject.transform.position;
					}
				}
				else
				canDJ = false;
				isTouchingGround = false;
			}
		
	}
	
	//checking that player is on the ground
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Floor")
		{
			canDJ = true;
			Counter = 0;
			canSJ = true;
			isTouchingGround = true;
		}
	}
}
