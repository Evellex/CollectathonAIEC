using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public float tTL = 5;
	// Use this for initialization
	void Start () {
	Destroy(gameObject,tTL);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
