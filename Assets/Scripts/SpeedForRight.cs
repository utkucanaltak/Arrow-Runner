using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedForRight : MonoBehaviour
{
    [SerializeField] private float rightSpeed;
    private GameObject SpeedRight;
    void Start()
    {
        SpeedRight = GetComponent<GameObject>();

    }

    void Update()
    {
        Rigidbody rs = SpeedRight.GetComponent<Rigidbody>();
        rs.velocity = Vector3.forward * rightSpeed * Time.deltaTime;
    }
}
