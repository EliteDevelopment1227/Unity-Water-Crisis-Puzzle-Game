﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu() {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");

    }
}
