using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles1 : MonoBehaviour
{
    public float obsSpeed;
    public bool moveRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(obsSpeed * Time.deltaTime, 0, 0);

        }

        else
        {
            transform.Translate(-(obsSpeed * Time.deltaTime), 0, 0);
        }
        
    }

      private void OnTriggerEnter(Collider Coll)
    {
        if (Coll.tag == "turn")
        {
            Debug.Log("Collied");
            
        }
    }
}
