using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectScript : MonoBehaviour {

	// Use this for initialization

public string Message;
public float Range;
public float Cooldown;
public float Duration;
	void Start () {
		Destroy(gameObject, Duration);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
