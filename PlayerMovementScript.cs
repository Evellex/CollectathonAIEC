using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	int forwardSpeed = 50;
	float forwardSpeedInAir = 2.5f;
	int strafeSpeed = 50;
	float strafeSpeedInAir = 2.5f;
	int rotateSpeed = 10;
	public float maxVelocity;
	public float customDrag;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Movement, faster on the ground slower in the air
		if (JumpingScript.isTouchingGround == true)
		{
			if (rigidbody.velocity.magnitude < 25){
			rigidbody.AddForce(-Input.GetAxis("Horizontal") * transform.forward * Time.deltaTime * forwardSpeed, ForceMode.VelocityChange);
			rigidbody.AddForce(Input.GetAxis("Vertical") * transform.right * Time.deltaTime * strafeSpeed, ForceMode.VelocityChange);
			}
		}
		else if (JumpingScript.isTouchingGround == false)
		{
			if (rigidbody.velocity.magnitude < 25)
			{
			rigidbody.AddForce(-Input.GetAxis("Horizontal") * transform.forward * Time.deltaTime * forwardSpeedInAir, ForceMode.VelocityChange);
			rigidbody.AddForce(Input.GetAxis("Vertical") * transform.right * Time.deltaTime * strafeSpeedInAir, ForceMode.VelocityChange);
			}
		}
		
		transform.Rotate(transform.up, Input.GetAxis("Mouse X") * rotateSpeed);
		


		
		
	}
}
