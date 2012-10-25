using UnityEngine;
using System.Collections;

public class playerdeath : MonoBehaviour {
	
	public Vector3 startPosition;
	static public bool playerAlive = true;
	public float respawnTime;

	// Use this for initialization
	void Start () {
		
		startPosition = gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerAlive == false)
		{
			respawnTime += Time.deltaTime;
			if (respawnTime > 2)
			{
				gameObject.transform.position = startPosition;
				playerAlive = true;
				respawnTime = 0;
			}
		}
		
	}
}
