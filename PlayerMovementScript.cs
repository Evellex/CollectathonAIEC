using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	int forwardSpeed = 100;
	int strafeSpeed = 100;
	int rotateSpeed = 10;
	public float maxVelocity;
	public float customDrag;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (playerdeath.playerAlive == true)
		{
			rigidbody.AddForce(-Input.GetAxis("Horizontal") * transform.forward * Time.deltaTime * forwardSpeed, ForceMode.Impulse);
			rigidbody.AddForce(Input.GetAxis("Vertical") * transform.right * Time.deltaTime * strafeSpeed, ForceMode.Impulse);
			
			transform.Rotate(transform.up, Input.GetAxis("Mouse X") * rotateSpeed);
			
			if(rigidbody.velocity.magnitude> maxVelocity)
			{
				rigidbody.drag = customDrag;
			}
			else
			{
				rigidbody.drag = 0;
			}
			Debug.Log (rigidbody.velocity.magnitude);
		}
	}
}
