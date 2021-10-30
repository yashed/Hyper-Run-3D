using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManagemet : MonoBehaviour
{
    public Text Timer1;
    public Text Timer2;

    public GameObject GameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.Finish)
        {
            Destroy(Timer1);
            GameOverPanel.SetActive(true);
        }
    }
}
