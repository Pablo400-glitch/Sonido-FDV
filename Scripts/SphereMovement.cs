using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public Transform objective;
    public float speed = 2.5f;
    public AudioSource audioSource;

    private bool isMoving = false;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isMoving)
            {
                isMoving = true;
                audioSource.Play();
                audioSource.loop = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            isMoving = false;
            audioSource.Stop();
        }

        if (isMoving)
        {
            Vector3 direccion = (objective.position - transform.position).normalized;
            transform.Translate(direccion * speed * Time.deltaTime, Space.World);
        }
    }
}
