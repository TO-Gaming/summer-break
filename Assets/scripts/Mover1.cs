using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component moves its object in a fixed velocity.
 * NOTE: velocity is defined as speed+direction.
 *       speed is a number; velocity is a vector.
 */
public class Mover1: MonoBehaviour {
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;

    [SerializeField] float speed = 5f;
    float move = 4.5f;
    bool flag = true;

    void Update() {
        transform.position += velocity * Time.deltaTime * speed;
        //float horizontal = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        
        if (Input.GetKeyDown("space") && this.tag != "MainCamera")
        {
            
            if (flag)
            {
                
                Vector3 newpos = pos;
                newpos.x = move;
                transform.position = newpos;
                flag = false;
            }
            else
            {
                
                Vector3 newpos = pos;
                newpos.x = -move;
                transform.position = newpos;
                flag = true;
            }
            
        }

       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "eli")
        {
            SceneManager.LoadScene("lost");
        }

    }


}
