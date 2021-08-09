using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootActive : MonoBehaviour
{     

    public Camera cam;
    public GameObject arrowPreFab;
    public GameObject arrowSpawn;
    public float shootForce;
    public GameFlow GameFlow;
    private int shots;

    void Start()
    {
        shots = GameFlow.remainingShot;
        gameObject.GetComponent<Button>().onClick.AddListener(leftArrow);        
    }

    void leftArrow()
    {

            if (GameFlow.remainingShot != 0)
            {
                GameObject go = Instantiate(arrowPreFab, arrowSpawn.transform.position, Quaternion.identity) as GameObject;
                Rigidbody rb = go.GetComponent<Rigidbody>();
                rb.velocity = cam.transform.forward * shootForce;
            }        
    }
}
