using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {
	
	public GameObject Player;
	public GameObject Bullet;
	float speedOfBullet = 100;
	float shotCoolDown = 2;
	float Timer = 0;
	public int range;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt (Player.transform.position);
		
		Timer += Time.deltaTime;
		
		if(Timer > shotCoolDown&&((transform.position - Player.transform.position).magnitude)<range)
		{
			Timer = 0;
			GameObject TempGameObject = Instantiate(Bullet,transform.position + Vector3.up,transform.rotation) as GameObject;
			
			if(TempGameObject.rigidbody != null)
			{
				TempGameObject.rigidbody.velocity = transform.forward * speedOfBullet;	
			}
		}
	
	}
}
