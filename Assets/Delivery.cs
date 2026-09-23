using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Debug.Log("Hit object!");
        if (collision.gameObject.CompareTag("EvilObstacle"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Grabbed Package!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Delivered Package!");

    }
}


