using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyValue : MonoBehaviour
{
    [SerializeField] private Text numberOfArrowsText;
    [SerializeField] int point_value;

    public int numberofArrows = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Arrow"))
        {
            
            AddScore();
            
        }
    }
        
    private void AddScore()
    {
        numberofArrows += point_value;
        numberOfArrowsText.text = numberofArrows.ToString();
    }
}
