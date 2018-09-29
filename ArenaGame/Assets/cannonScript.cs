using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonScript : MonoBehaviour {

	public GameObject ammo;
	public float reloadTimeMin;
	public float reloadTimeMax;
	public Transform shootPoint;

	public bool canShoot = false;

	// Use this for initialization
	void Start () {

		reload();

	}
	
	// Update is called once per frame
	void Update () {

		if(canShoot == true) {


			shoot();
		}
		
	}

	IEnumerator reload() {
		
		float reloadTime = Random.Range(reloadTimeMin, reloadTimeMax);
		yield return new WaitForSeconds(reloadTime);
		canShoot = true;
		yield return null;
	}


	void shoot() {

		canShoot = false;
		Instantiate(ammo, shootPoint.position, shootPoint.rotation, shootPoint);
		StartCoroutine(reload());
	}


}
