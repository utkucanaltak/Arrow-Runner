using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class boss2value : MonoBehaviour
{
    [SerializeField] private Text numberOfArrowsText;
    public GameObject ScoreManager;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            GetComponent<BoxCollider>().enabled = false;
            ScoreManager.GetComponent<ScoreManager>().bossScore += 5;
            ScoreManager.GetComponent<ScoreManager>().score += ScoreManager.GetComponent<ScoreManager>().bossScore -5;
        }
    }
}