using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public Animator anim;

    public GameObject Player;

    public Transform SpawnPos1;
    public Transform SpawnPos2;


    bool Fall;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Fall", Fall);
    }

    void SpawnPlayer1()
    {
        Instantiate(Player,SpawnPos1.position ,Quaternion.identity );
    
    }

    void SpawnPlayer2()
    {
        Instantiate(Player, SpawnPos2.position, Quaternion.identity);
    }

    //Player Management (Respawn / Dead / Fall)
    private void OnTriggerEnter(Collider Coll)
    {
        if (Coll.tag == "Hummer")
        {
            Debug.Log("Hummer Collied");
            Fall = true;
        }

        if (Coll.tag == "respawn")
        {
            Fall = false;
            Destroy(gameObject);
            SpawnPlayer1();
        }

        if (Coll.tag == "Traiangal")
        {
            Destroy(gameObject);

        }
    }
}
