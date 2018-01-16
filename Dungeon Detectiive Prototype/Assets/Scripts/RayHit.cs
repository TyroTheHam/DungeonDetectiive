using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

//Tag objects

public class RayHit : MonoBehaviour
{
    private Canvas PressE;
    //GameObject PressE;
    
    void Update()
    {   //PressE.enabled = true;
        //PressE = GameObject.Find("PressE").GetComponent<Canvas>();
        RaycastHit hit;
        float TheDistance;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 4;

        Debug.DrawRay(transform.position, forward, Color.green);
        
        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            TheDistance = hit.distance;
            //print(hit.collider.gameObject.name + "  " + TheDistance);


            //add tags to what ever you want to detect
            //Enemies
            if (TheDistance <= 4 && hit.transform.tag == "Enemy" ) 
            {
                SceneManager.LoadScene("InCombat");
            }
            //Doors
            if (TheDistance <= 4 && hit.transform.tag == "Door")
            {
                if (Input.GetKeyDown("e"))
                {
                    Debug.Log("DOOR DETECTED");
                }
            }
            if (TheDistance <= 4 && hit.transform.tag == "Note")
            {
                if (Input.GetKeyDown("e"))
                {
                    Debug.Log("Paper");
                    PressE.enabled = true;
                }
                if (Input.GetKeyDown("space"))
                {
                    PressE.enabled = false;
                }
            }
        }

    }
}