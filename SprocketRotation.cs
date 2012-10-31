using UnityEngine;
using System.Collections;

public class SprocketRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate(transform.right, Time.deltaTime * 100.0f);
	}
}
