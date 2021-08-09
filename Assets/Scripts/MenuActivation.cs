using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuActivation : MonoBehaviour
{
    public Button menuButton;
    public Button pauseButton;
    public Image menuPanel;

    public TextMeshProUGUI PauseButtonText;

    bool isPauseClicked = false;

    public void OpenMenuPanel()
    {
        menuPanel.gameObject.SetActive(true);
    }

    public void PauseGame()
    {
        if (!isPauseClicked)
        {
            Time.timeScale = 0;
            PauseButtonText.text = "Play";
            isPauseClicked = true;
        }
        else if(isPauseClicked)
        {
            Time.timeScale = 1;
            PauseButtonText.text = "Pause";
            isPauseClicked = false;
            menuPanel.gameObject.SetActive(false);
        }
    }
}
