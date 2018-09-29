using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScream : MonoBehaviour {

public string message; 

public float range;
public float cooldown;
public float power;
public float duration;


	// Use this for initialization
	void Start () {
		Destroy(gameObject, duration);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
