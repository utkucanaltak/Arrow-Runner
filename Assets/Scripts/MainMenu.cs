using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public GameFlow GameFlow;
    //public GameCamera GameCamera;
    //public ArrowRight ArrowRight;
    //public ArrowLeft ArrowLeft;
    //public ScoreManager ScoreManager;
    //public MenuActivation MenuActivation;
    //public ShootActive ShootActive;
    //public ShootActiveRight ShootActiveRight;
    //public GameObject Canvas;
    //public GameObject PlayGroup;

    public void PlayGame()
        
    {
        SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //GameFlow.gameObject.SetActive(true);
        //GameCamera.gameObject.SetActive(true);
        //ArrowRight.gameObject.SetActive(true);
        //ArrowLeft.gameObject.SetActive(true);
        //ScoreManager.gameObject.SetActive(true);
        //MenuActivation.gameObject.SetActive(true);
        //ShootActive.gameObject.SetActive(true);
        //ShootActiveRight.gameObject.SetActive(true);
        //Canvas.gameObject.SetActive(true);
        //PlayGroup.gameObject.SetActive(false);
    }
}
