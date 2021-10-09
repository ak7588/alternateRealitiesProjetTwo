using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour

{
    public bool taskOneCompleted = false;
    public bool taskTwoCompleted = false;
    public bool taskThreeCompleted = false;
    public AudioSource santaVoice;

    public GameObject arrowNav1;
    public GameObject arrowNav2;
    public GameObject arrowNav3;
    public GameObject arrowNav4;
    public GameObject arrowNav5;

    // Start is called before the first frame update
    void Start()
    {
        arrowNav1.SetActive(true);
        arrowNav2.SetActive(true);
        arrowNav3.SetActive(false);
        arrowNav4.SetActive(false);
        arrowNav5.SetActive(false);
    }

    private void Update()
    {
        if (taskOneCompleted) {
            santaVoice.Play();
            arrowNav1.SetActive(false);
            arrowNav2.SetActive(false);
            arrowNav3.SetActive(true);
            arrowNav4.SetActive(true);
            arrowNav5.SetActive(true);
        }

        if (taskTwoCompleted) {
            santaVoice.Play();
            arrowNav3.SetActive(false);
            arrowNav4.SetActive(false);
            arrowNav5.SetActive(false);
        }

        if (taskOneCompleted && taskTwoCompleted) {
            // play win sound
            santaVoice.Play();
        }
    }
}
