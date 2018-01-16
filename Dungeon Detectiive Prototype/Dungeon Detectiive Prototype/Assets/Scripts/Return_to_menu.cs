using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_to_menu : MonoBehaviour {

    private static Return_to_menu instance;

    //Singleton pattern
    private void Start()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(this);
    }


    public void Menu(string name)
    {
        try
        {
            SceneManager.LoadScene(name);
        }

        catch (Exception e)
        {
            throw new Exception("Scene does not exist");
        }

    }
}
