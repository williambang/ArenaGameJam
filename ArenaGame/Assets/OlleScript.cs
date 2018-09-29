using System;
using UnityEngine;

public class OlleScript : MonoBehaviour
{
	public float speed;
	public int health;
	public string playerName;
    public GameObject DeflectAbility;
	public Transform player;

	void Start() {
	Instantiate(DeflectAbility, player.position, player.rotation, player);
	}

    private void Instantiate(GameObject deflectAbility, object position, object rotation, Transform player)
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, z);
    }

	public void takeDamage(int damage) {

		health = health - damage;

	}

   // void Deflect() {
	//	Instantiate(OlleEffect, player.position, player.rotation, player);
	//}
}