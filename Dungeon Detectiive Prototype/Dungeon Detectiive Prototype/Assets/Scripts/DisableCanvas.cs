using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCanvas : MonoBehaviour
{

    private Canvas Logo;

    void Start()
    {
        Logo = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Logo.enabled = false;
        }
    }
}
