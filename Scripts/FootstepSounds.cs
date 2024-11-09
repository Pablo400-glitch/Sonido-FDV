using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip footstepSound;

    public float stepDistance = 1.0f;
    public float stepCooldown = 0.5f;

    private Vector3 lastPosition;
    private float lastStepTime = 0.0f;
    private bool isGrounded = false;

    private void Awake()
    {
        lastPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        isGrounded = IsGrounded();

        if (isGrounded && HasMoved())
        {

            if (Time.time - lastStepTime >= stepCooldown)
            {
                PlayFootstepSound();
                lastStepTime = Time.time;
            }
        }
    }

    private bool HasMoved()
    {
        float distanceMoved = Vector3.Distance(lastPosition, transform.position);

        if (distanceMoved >= stepDistance)
        {
            lastPosition = transform.position;
            return true;
        }

        return false;
    }

    private bool IsGrounded()
    {
        RaycastHit hit;
        return Physics.Raycast(transform.position, Vector3.down, out hit, 1.1f);
    }

    private void PlayFootstepSound()
    {
        if (audioSource && footstepSound)
        {
            audioSource.PlayOneShot(footstepSound);
        }
    }
}
