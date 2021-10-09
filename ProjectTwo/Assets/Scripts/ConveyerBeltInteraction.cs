using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerBeltInteraction : MonoBehaviour
{
    public GameObject blueGift;
    public AudioSource playSound;
    public GameObject grayBox;
    private MasterScript MasterScript;

    private void Start()
    {
        blueGift.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GrayBox"))
        {
            other.gameObject.SetActive(false);
            blueGift.SetActive(true);
            playSound.Play();
            MasterScript.taskOneCompleted = true;
        }
    }
}
