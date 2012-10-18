using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	int forwardSpeed = 10;
	int strafeSpeed = 10;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.AddForce(-Input.GetAxis("Horizontal") * transform.forward * Time.deltaTime * forwardSpeed, ForceMode.Impulse);
		rigidbody.AddForce(Input.GetAxis("Vertical") * transform.right * Time.deltaTime * strafeSpeed, ForceMode.Impulse);
	}
}
