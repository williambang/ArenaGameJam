﻿using UnityEngine;
using UnityEngine.UI;

public class OlleScript : MonoBehaviour
{
	public float speed;
	public int health;
	public string playerName;
	public Text healthUi;
	public Text deathUi;
	public GameObject[] abilites;
    public GameObject DeflectAbility;
	public Transform player;

	void Start() {
		healthUi.text = health.ToString();
	    Instantiate(DeflectAbility, player.position, player.rotation, player);
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, z);
    }

	public void takeDamage(int damage) {

		health = health - damage;
		healthUi.text = health.ToString();
		if(health <= 0) {
			die();
		}

	}

	void useAbility(int index) {
		GameObject ability = abilites[index];
		Instantiate(ability, transform.position, transform.rotation);
	}

	void die() {
		deathUi.text = "You Died";
		Destroy(gameObject);
	}
}