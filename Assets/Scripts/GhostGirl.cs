using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGirl : MonoBehaviour
{
    public bool playerEntered;
    public Renderer spriteRenderer;

    public AudioSource audioSource;
    public AudioClip ghostGirlEntry;

    void Start()
    {
        spriteRenderer = GetComponent<Renderer>();
        spriteRenderer.enabled = false;
    }

    void Update()
    {
        if (playerEntered)
        {
            spriteRenderer.enabled = true;
        }
        else if(!playerEntered)
        {
            spriteRenderer.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEntered = true;
            audioSource.PlayOneShot(ghostGirlEntry);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEntered = false;
        }
    }
}
