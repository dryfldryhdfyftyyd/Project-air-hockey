using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    private AudioSource audioSource;
    SpriteRenderer renderer;
    Rigidbody2D rb;
    void Start()

    {
        audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (! renderer.isVisible)
        {
            rb.velocity = Vector2.zero;
            transform.position = Vector3.zero;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (audioSource != null)
        {
            audioSource.volume = collision.relativeVelocity.magnitude / 30;
            audioSource.Play();
        }
        
    }
}
