using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    private AudioSource audioSource;
    int score = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pin"))
        {
            scoreTxt.text = (++score).ToString();
            audioSource.Play();
           
        }
        

    }
}
