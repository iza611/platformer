﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape")) Application.Quit();
        //if (Input.GetKey("space")) SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
