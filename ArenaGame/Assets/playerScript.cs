using UnityEngine;

public class playerScript : MonoBehaviour
{
	public float speed;
	public int health;

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;


        transform.Translate(x, 0, z);
<<<<<<< HEAD
        //moveplayer();
    }


    void moveplayer()
    {
        Debug.Log("scream");
=======
        MovePlayer();
    }

    void MovePlayer()
    {
        Debug.Log("Blabladick");
>>>>>>> d0fa94580aa23e488a44c17978d21fafc981771b
    }
}