using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip Hit, Fall, Finish;
    static AudioSource AudioSrc;


    // Start is called before the first frame update
    void Start()
    {
        Hit = Resources.Load<AudioClip>("hit");
        Fall = Resources.Load<AudioClip>("fall");
        Finish = Resources.Load<AudioClip>("finish");

        AudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hit":
                AudioSrc.PlayOneShot(Hit);
                break;
            case "fall":
                AudioSrc.PlayOneShot(Fall);
                break;
            case "finish":
                AudioSrc.PlayOneShot(Finish);
                break;



        }
    
    }
}
