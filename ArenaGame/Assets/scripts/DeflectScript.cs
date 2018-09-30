using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectScript : MonoBehaviour {

	// Use this for initialization

public string Message;
public float Range;
public float Cooldown;
public float Duration;
public float InvertBullet = -10.0f;
	void Start () {
		Destroy(gameObject, Duration);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision hitMe)
	{
		if(hitMe.gameObject.tag == "ammo") {
			hitMe.gameObject.GetComponent<bulletScript>().speed = InvertBullet;
		}
	}
}
