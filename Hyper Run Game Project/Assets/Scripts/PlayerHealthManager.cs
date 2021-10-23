using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    bool Fall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Player Management (Respawn / Dead / Fall)
    private void OnTriggerEnter(Collider Coll)
    {
        if (Coll.tag == "Hummer")
        {
            Debug.Log("Hummer Collied");
            Fall = true;
        }
    }
}
