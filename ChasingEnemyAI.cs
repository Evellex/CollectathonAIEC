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
			Debug.DrawRay(transform.position,storeFirstPosition,Color.blue);
		}
		else
		{
			if (transform.position != randDest)
			{
				transform.position = Vector3.MoveTowards(transform.position,randDest,walkSpeed*Time.deltaTime);
			}
			else
			{
				randDest = (Random.insideUnitSphere * 30)+storeFirstPosition;
				randDest.y = storeFirstPosition.y;
				transform.LookAt(randDest);
			}
		}

	}

}
