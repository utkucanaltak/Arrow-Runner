using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedForLeft : MonoBehaviour
{
    [SerializeField] private float leftSpeed;
    private GameObject SpeedLeft;
    void Start()
    {
        SpeedLeft = GetComponent<GameObject>();

    }

    void Update()
    {
        Rigidbody ls = SpeedLeft.GetComponent<Rigidbody>();
        ls.velocity = Vector3.forward * leftSpeed * Time.deltaTime;
    }
}