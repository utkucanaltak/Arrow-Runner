using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public GameObject numberOfArrowsText;
    public int bossScore = 0;

    void Update()
    {
        numberOfArrowsText.GetComponent<Text>().text = score.ToString();

        //if (bossScore == 2)
        //{
            //    LevelCompletedUI.SetActive(true);
            //    yield return new WaitForSeconds(1.0f);

            //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
    }

}

