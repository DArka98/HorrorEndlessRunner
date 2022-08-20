using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameManager gameManager;

    public AudioSource audioSource;
    public AudioClip deathSound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            audioSource.PlayOneShot(deathSound);
            gameManager.gameOver = true;
        }
    }
}
