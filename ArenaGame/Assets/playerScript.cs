using UnityEngine;

public class playerScript : MonoBehaviour
{
	public float speed;
	public int health;

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, z);
    }
}