using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleighTakeOff : MonoBehaviour
{
    private Vector3 startPos, endPos;
    private float lerp = 0, duration = 6;
    public bool isMoving = false;

    private void Start()
    {
        startPos = transform.position;
        endPos = GameObject.Find("endPos").transform.position;
    }

    private void Update()
    {
        if (isMoving) {
            lerp += Time.deltaTime / duration;
            transform.position = Vector3.Lerp(startPos, endPos, lerp);
        }
    }
}
