using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arenaScript : MonoBehaviour {

	// Use this for initialization
	public float rotationSpeed;
	public bool rotateLeft;
	
	// Update is called once per frame
	void Update () {

		float rotation = rotationSpeed * Time.deltaTime;
		transform.Rotate(0,rotation,0);
	}
}
