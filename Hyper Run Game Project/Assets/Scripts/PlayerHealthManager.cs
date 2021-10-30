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
        
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Fall", Fall);


        
    }

    void SpawnPlayer1()
    {
        Collider.isTrigger = false;
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
            Collider.isTrigger = true;
            Fall = true;
            SoundManager.PlaySound("hit");
            Debug.Log("Hummer Collied");
            
        }

        if (Coll.tag == "respawn")
        {
            
           // Destroy(gameObject);
            SpawnPlayer1();
            Player.SetActive(false);

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

        if (Coll.tag == "reset")
        {
            Fall = false;
        }
    }
}
