﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam1Follow : MonoBehaviour
{
    public Transform target;
    float smoothing = 4f;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.fixedDeltaTime);

    }
}
