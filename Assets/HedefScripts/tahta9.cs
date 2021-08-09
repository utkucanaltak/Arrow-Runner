using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tahta9 : MonoBehaviour
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
            ScoreManager.GetComponent<ScoreManager>().score += -4;
        }
    }
}
