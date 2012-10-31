using UnityEngine;
using System.Collections;

public class ChasingEnemyAI : MonoBehaviour {

	float timer;
	float walkTimeLength = 1;
	float walkSpeed = 5;
	public float patrolRadius;
	public float chaseRadius;
	public Vector3 randDest = new Vector3();
	public Vector3 storeFirstPosition = new Vector3();

	public GameObject player;
	// Use this for initialization
	void Start () {

		storeFirstPosition = transform.position;

	randDest = (Random.insideUnitSphere * patrolRadius )+storeFirstPosition;
	randDest.y = storeFirstPosition.y;

		transform.LookAt(randDest);

	}

	// Update is called once per frame
	void Update () {
		Debug.Log((transform.position - player.transform.position).magnitude);

		if (((transform.position - player.transform.position).magnitude) < chaseRadius)
		{
			transform.position = Vector3.MoveTowards(transform.position,player.transform.position,walkSpeed*Time.deltaTime);
			transform.LookAt(player.transform);
		}
		else
		{
			if (transform.position != randDest)
			{
				transform.position = Vector3.MoveTowards(transform.position,randDest,walkSpeed*Time.deltaTime);
				Debug.DrawRay(transform.position,storeFirstPosition-transform.position,Color.blue);
				Debug.DrawRay(transform.position,randDest-transform.position,Color.red);
			}
			else
			{
				randDest = (Random.insideUnitSphere * 30)+storeFirstPosition;
				randDest.y = storeFirstPosition.y;
				transform.LookAt(randDest);
			}
		}

	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag =="Player")
		{
			playerdeath.playerAlive = false;
			//playerdeath.timeToRespawn = 0.2f;
		}
	}

}