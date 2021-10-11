using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerBeltInteraction : MonoBehaviour
{
    public GameObject blueGift;
    public AudioSource playSound;
    public GameObject grayBox;
    public GameObject arrowNav1;
    public GameObject arrowNav2;
    public GameObject arrowNav3;
    public GameObject arrowNav4;
    public GameObject arrowNav5;
    public GameObject arrowNav6;
    //private MasterScript MasterScript;

    private void Start()
    {
        blueGift.SetActive(false);
        arrowNav1.SetActive(true);
        arrowNav2.SetActive(true);
        arrowNav3.SetActive(false);
        arrowNav4.SetActive(false);
        arrowNav5.SetActive(false);
        arrowNav6.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GrayBox"))
        {
            arrowNav1.SetActive(false);
            arrowNav2.SetActive(false);
            arrowNav3.SetActive(true);
            arrowNav4.SetActive(true);
            arrowNav5.SetActive(true);
            arrowNav6.SetActive(true);

            other.gameObject.SetActive(false);
            blueGift.SetActive(true);
            playSound.Play();
        }
    }
}
