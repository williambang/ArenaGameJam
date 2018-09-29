using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeBubble : MonoBehaviour {

	// Use this for initialization

	public float speedDecrease = 3.0f;
	public float duration;
	public float range;

	void Start () {
		
		transform.localScale = new Vector3(range, range, range);
		
		Destroy(gameObject, duration);

	}
	
	void OnTriggerEnter(Collider other) {

		if(other.tag == "ammo"){
			other.gameObject.GetComponent<bulletScript>().speed = speedDecrease;
		}

	}

}
