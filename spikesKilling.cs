using UnityEngine;
using System.Collections;

public class spikesKilling : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		playerdeath.timeToRespawn = 0.3f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	void OnCollisionEnter(Collision collision)
	{
		if ( collision.gameObject.tag == "Player")
		{
			playerdeath.playerAlive = false;
			playerdeath.timeToRespawn = 2;
		}
	}
}

