using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeBubble : MonoBehaviour {

	// Use this for initialization

	public float speedDecrease = 3.0f;

	void Start () {
		
	}
	
	void OnTriggerEnter(Collider other) {

		if(other.tag == "ammo"){
			other.gameObject.GetComponent<bulletScript>().speed = speedDecrease;
		}

	}

}
