using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{

    public static int remainingShot = 12;
    public Text shotCounterText;

    void Start()
    {
        remainingShot = 12;
        shotCounterText.GetComponent<Text>().text = remainingShot.ToString();
    }

    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
       {
            if (remainingShot != 0) 
            {
                remainingShot -= 1;
            }
            else
            {
                remainingShot = 0;
            }
            shotCounterText.GetComponent<Text>().text = remainingShot.ToString();
       } 
    }
}
