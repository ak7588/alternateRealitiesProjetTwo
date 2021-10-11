using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class BucketController : MonoBehaviour
{
    public MeshRenderer bucketRenderer;
    public AudioSource playSound;
    private int count = 0;
    public GameObject arrowNav3;
    public GameObject arrowNav4;
    public GameObject arrowNav5;
    public GameObject arrowNav6;
    public GameObject arrowNav7;
    public GameObject arrowNav8;

    private void Start()
    {
        arrowNav7.SetActive(false);
        arrowNav8.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gift")) {
            other.gameObject.GetComponent<XRBaseInteractable>().enabled = false;
            count += 1;
            if (count == 3)
            {
                playSound.Play();
                arrowNav3.SetActive(false);
                arrowNav4.SetActive(false);
                arrowNav5.SetActive(false);
                arrowNav6.SetActive(false);
                arrowNav7.SetActive(true);
                arrowNav8.SetActive(true);
            }
        }
    }
}
