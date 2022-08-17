using UnityEngine;
public class DestroyObstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Border")) 
        {    
            Destroy(gameObject);
        }
        else if(collision.CompareTag("Player")) 
        {
            PlayerController.Instance.PlayerDied();
        }
    }
}