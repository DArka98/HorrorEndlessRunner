using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGirl02 : MonoBehaviour
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
        if (playerEntered && transform.position.z >= 0)
        {
            spriteRenderer.enabled = true;

            var pos = transform.position;
            pos.z -= 1.0f; 
            transform.position = pos;

            if((int)pos.z % 10 == 0)
            {
                spriteRenderer.enabled = true;
            }
            else
            {
                spriteRenderer.enabled = false;
            }
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
}
