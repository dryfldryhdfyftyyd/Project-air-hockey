using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed = 5f;
    
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    Vector3 startPos;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        startPos = transform.position;
    }

    void Update()
    {
        //check if mouse is inside screen bounds
        if (Input.mousePosition.x < 0 || Input.mousePosition.x > Screen.width ||
            Input.mousePosition.y < 0 || Input.mousePosition.y > Screen.height)
            //Input.mousePosition.x < Screen.width / 2)
        {
            return;
        }
        
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        
        var targetPos = Vector2.MoveTowards(transform.position, worldPos, speed * Time.deltaTime);
        
        if(targetPos.x > 0) rb.MovePosition(targetPos);
        //transform.position = worldPos;

        if (!spriteRenderer.isVisible)
        {
            rb.velocity = Vector2.zero;
            transform.position = startPos;
        }
    }
}
