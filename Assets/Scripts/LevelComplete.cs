using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelComplete : MonoBehaviour
{
    public ScoreManager ScoreManager;
    public GameObject LevelCompletedUI;

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            //BossScorePlusScore();
            LevelCompleted();
        }
    }

    public void LevelCompleted()
    {
        if(ScoreManager.score >= 20)
        {

            LevelCompletedUI.SetActive(true);

            StartCoroutine(BEKLE());

            IEnumerator BEKLE()
                {
                yield return new WaitForSeconds(1.0f);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }   
}
