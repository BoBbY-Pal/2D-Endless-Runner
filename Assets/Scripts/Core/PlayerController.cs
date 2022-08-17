using GenericSingleton;
using UI;
using UnityEngine;

public class PlayerController : MonoGenericSingleton<PlayerController>
{   
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();   
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
    
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        
        ScoreManager.Instance.UpdateScore();
    }
    
    public void PlayerDied()
    {
        Destroy(gameObject); 
        UIHandler.Instance.GameOver();
    }
}
