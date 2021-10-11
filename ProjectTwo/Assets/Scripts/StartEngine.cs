using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEngine : MonoBehaviour
{
    public GameObject loc;
    public GameObject keyCopy;
    public GameObject key;
    public float speed = 200.0f;
    public AudioSource santaVoice;
    public AudioSource final;
    public GameObject arrowNav7;
    public GameObject arrowNav8;
    private bool taskCompleted = false;
    private bool isPlaying = false;

    private void Start()
    {
        keyCopy.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
            arrowNav7.SetActive(false);
            arrowNav8.SetActive(false);
            //keyCopy.SetActive(true);
            //key.SetActive(false);
            taskCompleted = true;
        }
    }

    private void Update()
    {
        if (taskCompleted && !isPlaying)
        {
            santaVoice.Play();
            final.Play();
            isPlaying = true;
        }

        if (taskCompleted && isPlaying) {
            final.Play();
        }
    }
}
