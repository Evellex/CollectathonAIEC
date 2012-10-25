using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	int forwardSpeed = 1000;
	int strafeSpeed = 1000;
	int rotateSpeed = 10;
	public float maxVelocity;
	public float customDrag;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.AddForce(-Input.GetAxis("Horizontal") * transform.forward * Time.deltaTime * forwardSpeed, ForceMode.Impulse);
		rigidbody.AddForce(Input.GetAxis("Vertical") * transform.right * Time.deltaTime * strafeSpeed, ForceMode.Impulse);
		
		if (Input.GetKey(KeyCode.None))
		{
			rigidbody.mass = 10;
		}
		transform.Rotate(transform.up, Input.GetAxis("Mouse X") * rotateSpeed);
		
		if(rigidbody.velocity.magnitude > maxVelocity)
		{
			rigidbody.drag = customDrag;
		}
		else
		{
			rigidbody.drag = 0;
			rigidbody.mass = 100;
		}
		
	}
}
