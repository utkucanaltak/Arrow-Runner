using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    [SerializeField] private float camSpeed;
    //[SerializeField] private bool isGameFinished=false;
    //[SerializeField] private float lerpValue;

    public AudioSource DoorJumpMusic;


    private Rigidbody rbody;
    private Camera cam;
    void Start()
    {
        rbody = GetComponent<Rigidbody>();

        StartCoroutine(PlayJumpMusic());
        //cam = Camera.main;
    }

    void FixedUpdate()
    {
    rbody.velocity = Vector3.forward * camSpeed * Time.deltaTime;  
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        DoorJumpMusic.Play();

    }


    //   private void CharacterMovement()
    //   {
    //        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //
    //        if(Physics.Raycast(ray,out hit))
    //        {
    //            Vector3.Lerp(abody.transform.position,new Vector3(abody.transform.position.x,hit.transform.position.y,hit.transform.position.z), lerpValue);
    //        }
    //   }
}
