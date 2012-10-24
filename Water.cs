using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour {
	
	static public bool playerAlive = true;
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
			playerAlive = false;
		}
	}
}
