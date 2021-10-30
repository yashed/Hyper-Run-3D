using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables 
    public Rigidbody Rb;
    public Animator anim;

    //Float variables to player controll
    public float speed;
    public float JumpSpeed;
    float VarVal;

    //Bool variables for the player animation management
    bool Jump;
    bool Run;
    bool Climb;
    public static bool Finish = false;

    //add partical systems
    public ParticleSystem P1;
    public ParticleSystem P2;
    public ParticleSystem P3;
    public ParticleSystem P4;



    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Assing Verical value to the VarVal
        VarVal = Input.GetAxisRaw("Vertical");


        //Player Run
        if (VarVal > 0.1 && Climb == false && Run == true)
        {
            Debug.Log("VarVal 1");
            transform.position += Vector3.forward * Time.deltaTime * speed;

        }

        //Player Climb
        else if (VarVal > 0.1 && Climb == true)
        {
            Rb.useGravity = false;
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        //Player Jump
        else if (VarVal > 0.1 && Jump == true)
        {
            Debug.Log("jemp speed");
            transform.position += Vector3.forward * Time.deltaTime * JumpSpeed;
        }

       

        //Set Animator Parameters to the variables
        anim.SetFloat("Run", VarVal);
        anim.SetBool("jump", Jump);
        anim.SetBool("climb", Climb);
        anim.SetBool("Dance", Finish);
    }


    private void OnTriggerEnter(Collider Coll)
    {

        if (Coll.tag == "Jump")
        {
            JumpSpeed = 35f;
            Debug.Log("jump");
            Jump = true;
            Run = false;
            Climb = false;
        }

        if (Coll.tag == "Jump1")
        {
            JumpSpeed = 20f;
            Run = false;
            Climb = false;
            Jump = true;
        
        }
        if (Coll.tag == "Ground")
        {
            Debug.Log("jump false");
            Jump = false;
            Run = true;
            Climb = false;
        }

        if (Coll.tag == "Climb")
        {
            Climb = true;
            Run = false;
            Jump = false;
        }
        if (Coll.tag == "finish")
        {
            SoundManager.PlaySound("finish");
            Finish = true;
            Run = false;
            Jump = false;

            P1.Play(true);
            P2.Play(true);
            P3.Play(true);
            P4.Play(true);
        
        }

       

        
    }
}
