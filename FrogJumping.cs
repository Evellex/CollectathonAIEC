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
		if (timeWated > random)
		{
			jumpTime += Time.deltaTime;
			if (jumpTime < 2)
			{
				gameObject.rigidbody.AddForce(0, 5, 0);
			}
			timeWated = 0; 
		}
	}
}

