using UnityEngine;
using System.Collections;

public class ChasingEnemyAI : MonoBehaviour {
	
	float timer;
	float walkTimeLength = 1;
	float walkSpeed = 10;
	public float patrolRadius = 30;
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
		
		if ((storeFirstPosition - player.transform.position).magnitude < 5)
		{
			Debug.Log((storeFirstPosition - player.transform.position).magnitude);
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
	/*void OnTriggerExit(Collider collider)
	{
		transform.Rotate(0,180,0);
	}*/
}
