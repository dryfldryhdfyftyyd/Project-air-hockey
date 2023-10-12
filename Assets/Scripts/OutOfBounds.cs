using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    SpriteRenderer renderer;
    Rigidbody2D rb;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (!renderer.isVisible)
        {
            rb.velocity = Vector2.zero;
            transform.position = startPos;
        }
    }
}
