using UnityEngine;

public class playerScript : MonoBehaviour
{
	public float speed;
	public int health;
	public string playerName;

	void Start() {

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
}