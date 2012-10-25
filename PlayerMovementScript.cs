using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	int forwardSpeed = 50;
	int strafeSpeed = 50;
	int rotateSpeed = 10;
	public float maxVelocity;
	public float customDrag;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (rigidbody.velocity.magnitude < 25){
		rigidbody.AddForce(-Input.GetAxis("Horizontal") * transform.forward * Time.deltaTime * forwardSpeed, ForceMode.VelocityChange);
		rigidbody.AddForce(Input.GetAxis("Vertical") * transform.right * Time.deltaTime * strafeSpeed, ForceMode.VelocityChange);
		}
		
		transform.Rotate(transform.up, Input.GetAxis("Mouse X") * rotateSpeed);
		

		/*
		if (Input.GetKey(KeyCode.None))
		{
			rigidbody.mass = 1;
		}
		
		
		if(rigidbody.velocity.magnitude > maxVelocity)
		{
			rigidbody.drag = customDrag;
		}
		else
		{
			rigidbody.drag = 0;
			rigidbody.mass = 1;
		}*/
		
	}
}
