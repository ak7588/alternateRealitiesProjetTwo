using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

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
    private bool isRotating = false;
    private SleighTakeOff script;

    private Vector3 startPos, endPos;
    private float lerp = 0, duration = 6;
    private Quaternion startRot, endRot;


    private void Start()
    {
        keyCopy.SetActive(false);
        startPos = transform.position;
        endPos = GameObject.Find("LockPos").transform.position;
        startRot = transform.rotation;
        endRot = GameObject.Find("LockPos").transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            isRotating = true;
        }
    }

    private void Update()
    {
        if (isRotating)
        {
            lerp += Time.deltaTime / duration;
            transform.position = Vector3.Lerp(startPos, endPos, lerp);
            transform.rotation = Quaternion.Lerp(startRot, endRot, lerp);
            arrowNav7.SetActive(false);
            arrowNav8.SetActive(false);
            keyCopy.SetActive(true);
            key.SetActive(false);
            keyCopy.SetActive(true);
            taskCompleted = true;
        }

        if (taskCompleted && !isPlaying)
        {
            santaVoice.Play();
            final.Play();
            isPlaying = true;
        }
    }

    private void SleighTakesOff()
    {

    }
}


