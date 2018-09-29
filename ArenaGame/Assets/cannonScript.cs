using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonScript : MonoBehaviour {

	public GameObject ammo;
	public float reloadTime;
	public Transform shootPoint;

	// Use this for initialization
	void Start () {
		shoot();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void shoot() {
		Instantiate(ammo, shootPoint.position, shootPoint.rotation, shootPoint);
	}


}
