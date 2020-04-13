using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEditor;
using UnityEngine;
public class StartUp : MonoBehaviour
{

    public static GameObject uiObject;
    
    // Start is called before the first frame update

    private void OnEnable()
    {
        Debug.Log("game start");
        uiObject = GameObject.Find("UI");

        ButtonScript.OpenMenu("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
