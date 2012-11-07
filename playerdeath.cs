using UnityEngine;
using System.Collections;

public class playerdeath : MonoBehaviour {
	
	public Vector3 startPosition;
	static public bool playerAlive = true;
	public float respawnTimer;
	static public float timeToRespawn;
	public GameObject Explosion;
	bool hasExploded = false;
	// Use this for initialization
	void Start () {
		
		startPosition = gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(playerAlive);
		if (playerAlive == false)
		{
			gameObject.GetComponent<CapsuleCollider>().enabled = false;
			rigidbody.isKinematic = true;
			gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
			if (hasExploded == false)
			{
				GameObject TempGameObject = Instantiate(Explosion,transform.position,transform.rotation) as GameObject;
				hasExploded = true;
			}
			
			respawnTimer += Time.deltaTime;
			if (respawnTimer > timeToRespawn)
			{
				gameObject.transform.position = startPosition;
				playerAlive = true;
				respawnTimer = 0;
				hasExploded = false;
				gameObject.GetComponent<CapsuleCollider>().enabled = true;
				rigidbody.isKinematic = false;
			}
		}
		
	}
}
