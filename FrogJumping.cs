using UnityEngine;
using System.Collections;

public class FrogJumping : MonoBehaviour
{
	int random;
	float timeWated;
	float jumpTime = 2;

	// Use this for initialization
	void Start ()
	{
		random = Random.Range(10, 20);
	}
	
	// Update is called once per frame
	void Update ()
	{
		timeWated += Time.deltaTime;
		//Debug.Log(timeWated);
		//Debug.Log(random);
		if (timeWated > random)
		{
		 	gameObject.rigidbody.AddForce(transform.up*10, ForceMode.Impulse);
			timeWated = 0; 
			random = Random.Range(10, 40);
		}
	}
}

