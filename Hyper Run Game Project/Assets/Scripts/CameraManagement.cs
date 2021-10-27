using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagement : MonoBehaviour
{
    // Get All Cameras as Veriables
    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;
    public Camera Cam4;
    public Camera Cam5;

    //Bools for cameraFollow Scripts
    public static bool cam2 = false;
    public static bool cam3 = false;
    public static bool cam4 = false;
    public static bool cam5 = false;






    // Start is called before the first frame update
    void Start()
    {
        Cam1.enabled = true;
        Cam2.enabled = false;
        Cam3.enabled = false;
        Cam4.enabled = false;
        Cam5.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Trig)
    { 
        if (Trig.tag == "cam2")
        {
            cam2 = true;
            Cam1.enabled = false;
            Cam2.enabled = true;

        }

        if (Trig.tag == "cam3")
        {
            cam3 = true;
            Cam2.enabled = false;
            Cam3.enabled = true;
        }

        if (Trig.tag == "cam4")
        {
            cam4 = true;
            Cam3.enabled = false;
            Cam4.enabled = true;
        }

        if (Trig.tag == "cam5")
        {
            cam5 = true;
            Cam4.enabled = false;
            Cam5.enabled = true;
        }

    

    }
}
