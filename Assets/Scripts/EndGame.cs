using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject EndGameUI;

    void OnTriggerEnter(Collider Other)
    {
        if(Other.CompareTag("MainCamera"))
        {
            Time.timeScale = 0;
            

            EndGameUI.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            EndGameUI.SetActive(false);
        }
    }
    
}
