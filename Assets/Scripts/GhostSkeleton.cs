using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSkeleton : MonoBehaviour
{
    public bool playerEntered;
    public float speed = 10;
    public float upperlimit = -4.5f;

    public AudioSource audioSource;
    public AudioClip ghostSkeletonEntry;

    void Update()
    {
        if (playerEntered && transform.position.y > upperlimit)
        {
            var pos = transform.position;
            pos.y -= speed * Time.deltaTime;
            transform.position = pos;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEntered = true;
            audioSource.PlayOneShot(ghostSkeletonEntry);
        }
    }
}
