using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEngine : MonoBehaviour
{
    public GameObject loc;
    public float speed = 200.0f;
    public AudioSource santaVoice;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
            santaVoice.Play();
        }
    }
}
