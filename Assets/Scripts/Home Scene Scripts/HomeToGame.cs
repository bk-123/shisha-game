﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeToGame : MonoBehaviour
{

    public void NextScene()
    {

        SceneManager.LoadScene("Game");

    }

}
