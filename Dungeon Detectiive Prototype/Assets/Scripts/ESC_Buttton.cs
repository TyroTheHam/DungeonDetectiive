using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;
public class ESC_Buttton : MonoBehaviour {

    private static ESC_Buttton instance;

    void Start () {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(this);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {           
             SceneManager.LoadScene("PauseMenu");            
        }
    }    
}






//When a player reaches a certain point in a scene or act place a trigger which changes a value which tell weither the player has done/reached it then save the players position and the values of the check points
