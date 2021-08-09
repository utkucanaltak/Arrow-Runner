using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRight : MonoBehaviour
{
    Rigidbody arrowbody;
    //private float lifeTimer = 10f;
    //private float timer;
    private bool hitSomething = false;

    private void Start()
    {
        arrowbody = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.LookRotation(arrowbody.velocity);
    }

    private void Update()
    {
        if (!hitSomething)
        {
            transform.rotation = Quaternion.LookRotation(arrowbody.velocity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Arrow")
        {
            hitSomething = true;
            Stick();
        }

    }

    private void Stick()
    {
        arrowbody.constraints = RigidbodyConstraints.FreezeAll;
    }
}
