﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObject10 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}
