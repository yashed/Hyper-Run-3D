using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public Animator anim;

    public GameObject Player;
   

    public Transform SpawnPos1;
    public Transform SpawnPos2;

    public BoxCollider Collider;

    bool Fall;


    // Start is called before the first frame update
    void Start()
    {
        Collider.isTrigger = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Fall", Fall);


        if (Fall)
        {
            Collider.isTrigger = true;
        }
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
            SoundManager.PlaySound("hit");
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
            SoundManager.PlaySound("hit");
            Destroy(gameObject);
            SpawnPlayer2();

        }

        if(Coll.tag == "fall")
        {
            SoundManager.PlaySound("fall");

        }
    }
}
