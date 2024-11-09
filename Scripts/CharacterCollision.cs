using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollision : MonoBehaviour
{
    public AudioSource audioSource;

    public float maxVolume = 1.0f;
    public float minVolume = 0.1f; 
    public float maxImpactSpeed = 5f; 

    private float playerSpeed;
    private float volume;

    private void Awake()
    {
        playerSpeed = this.gameObject.GetComponent<CharacterMovement>().speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            if (playerSpeed >= maxImpactSpeed)
            {
                volume = maxVolume;
            } 
            else if (playerSpeed < maxImpactSpeed)
            {
                volume = minVolume;
            }

            audioSource.volume = volume;

            audioSource.Play();
        }
    }
}
