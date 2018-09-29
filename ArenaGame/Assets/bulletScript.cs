using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	public float speed;
	public int damage;
	
	// Update is called once per frame

	void Start() {
		Destroy(gameObject, 5);
	}

	void Update () {
		
		float distance = speed * Time.deltaTime;

		transform.Translate( 0, distance, 0 );

	}

	void OnCollisionEnter(Collision hitCollision) {

		Destroy(gameObject);
		
		if(hitCollision.gameObject.tag == "player") {
			hitCollision.gameObject.GetComponent<playerScript>().takeDamage(damage);
		}
	}
}
