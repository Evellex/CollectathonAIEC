using UnityEngine;
using System.Collections;

public class playerdeath : MonoBehaviour {
	
	public static Vector3 startPosition;
	static public bool playerAlive = true;
	public float respawnTimer;
	static public float timeToRespawn;
	public GameObject Explosion;
	bool hasExploded = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(playerAlive);
		if (playerAlive == false)
		{
			gameObject.GetComponent<CapsuleCollider>().enabled = false; //makes opject non collideable on death
			rigidbody.isKinematic = true; //Freezes position on death - will fall through world without
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
