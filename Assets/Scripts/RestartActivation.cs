using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class RestartActivation : MonoBehaviour
{
    public Button restartButton;

    bool isRestartClicked = false;

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        if (!isRestartClicked)
        {
            Time.timeScale = 1;

        }
    }
        
}
