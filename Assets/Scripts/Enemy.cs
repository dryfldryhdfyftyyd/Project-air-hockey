using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform pin;
    public float speed = 100;
    private Rigidbody2D rb;
    public Transform defencePoint;
    public float defenceSpeed = 15;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targrtPos;
        if (pin.position.x < 0)
        {
            targrtPos = Vector2.MoveTowards(transform.position, pin.position, speed * Time.deltaTime);

            rb.MovePosition(targrtPos);
        }
        else
        {
            targrtPos = Vector2.MoveTowards(transform.position, defencePoint.position, defenceSpeed * Time.deltaTime);

            rb.MovePosition(targrtPos);
        }
        
    }
}
