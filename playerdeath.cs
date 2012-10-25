using UnityEngine;
using System.Collections;

public class playerdeath : MonoBehaviour {
	
	public Vector3 startPosition;
	static public bool playerAlive = true;
	public float respawnTimer;
	static public float timeToRespawn;
	// Use this for initialization
	void Start () {
		
		startPosition = gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerAlive == false)
		{
			respawnTimer += Time.deltaTime;
			if (respawnTimer > timeToRespawn)
			{
				gameObject.transform.position = startPosition;
				playerAlive = true;
				respawnTimer = 0;
			}
		}
		
	}
}
