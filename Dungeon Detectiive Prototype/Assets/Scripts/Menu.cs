using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Menu class for menu buttons
/// </summary>
public class Menu : MonoBehaviour
{
    /// <summary>
    /// Creating an instance so that duplicate classes are not instantiated
    /// </summary>
    private static Menu instance;

    //Singleton pattern
    private void Start()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(this);
    }

    //Loads a scene from the specified name
    public void Play(string name)
    {
        try
        {
            SceneManager.LoadScene(name);
        }
#pragma warning disable CS0168 // Variable is declared but never used
        catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
        {
            throw new Exception("Scene name does not exist");
        }
    }

    //Quits (platform dependent)
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void Howtoplay(string name)
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