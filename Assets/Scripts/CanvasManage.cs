using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManage : MonoBehaviour
{
    public Slider PlayerPathBar;

    float Distance;
    float currentDistance;




    // Start is called before the first frame update
    void Start()
    {
        Distance = 10;
        currentDistance = 0;
        PlayerPathBar.maxValue = Distance;
        PlayerPathBar.value = currentDistance;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPathBar.value = currentDistance;
    }

    private void OnTriggerEnter(Collider Coll)
    {
        if (Coll.tag == "mark")
        {
            Debug.Log("add distance");
            currentDistance= currentDistance +1;
        }
    }
}
