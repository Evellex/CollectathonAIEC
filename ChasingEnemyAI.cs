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
		//setting the center point to the gators patrol
		storeFirstPosition = transform.position;
		//setting the first random target, X and Z are random
	randDest = (Random.insideUnitSphere * patrolRadius )+storeFirstPosition;
		//Y is set to the same plane as the center
	randDest.y = storeFirstPosition.y;
		//face the target
		transform.LookAt(randDest);

	}

	// Update is called once per frame
	void Update () {
		
		//if the player is within the defined Chase Radius
		if (((transform.position - player.transform.position).magnitude) < chaseRadius)
		{
			//look at and move towards it
			transform.position = Vector3.MoveTowards(transform.position,player.transform.position,walkSpeed*Time.deltaTime);
			transform.LookAt(player.transform);
		}
		else
		{
			if (transform.position != randDest)
			{
				//move to the patrol  point
				transform.position = Vector3.MoveTowards(transform.position,randDest,walkSpeed*Time.deltaTime);
				Debug.DrawRay(transform.position,storeFirstPosition-transform.position,Color.blue);
				Debug.DrawRay(transform.position,randDest-transform.position,Color.red);
			}
			else
			{
				//when you arive at the patrol point, find a new one
				randDest = (Random.insideUnitSphere * 30)+storeFirstPosition;
				randDest.y = storeFirstPosition.y;
				transform.LookAt(randDest);
			}
		}

	}
	//when you collide the player kill him
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag =="Player")
		{
			playerdeath.playerAlive = false;
			playerdeath.timeToRespawn = 2;
		}
	}

}