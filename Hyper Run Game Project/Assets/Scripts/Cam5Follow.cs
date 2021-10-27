using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam5Follow : MonoBehaviour
{
    public Transform target;
    public Transform CamColl;
    float smoothing = 4f;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {


        offset = transform.position - CamColl.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (CameraManagement.cam5 == true)
        {
            Vector3 targetCamPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.fixedDeltaTime);
        }
    }
}
