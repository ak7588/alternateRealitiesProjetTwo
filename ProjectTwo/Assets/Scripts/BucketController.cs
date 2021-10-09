using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class BucketController : MonoBehaviour
{
    public MeshRenderer bucketRenderer;
    public AudioSource playSound;
    private int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gift")) {
            count += 1;
            if (count == 3)
            {
                playSound.Play();
            }
        }
    }
}
