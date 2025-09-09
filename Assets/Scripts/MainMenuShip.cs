using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuShip : MonoBehaviour
{
    public bool turnRight;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (turnRight)
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        else if (!turnRight)
        {
            transform.Translate(-(Speed * Time.deltaTime), 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D Coll)
    {
        if (Coll.tag == "right")
        {
            Debug.Log("anithing");
            if (turnRight)
            {
                turnRight = false;
            }

            else
            {
                turnRight = true;
            }
        }
    }

    
}
