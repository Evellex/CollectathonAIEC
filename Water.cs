using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour {
	
	public GameObject Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			playerdeath.playerAlive = false;
		}
	}
}
