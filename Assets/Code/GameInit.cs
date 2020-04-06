﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInit : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("ui", LoadSceneMode.Additive);
    }
}
