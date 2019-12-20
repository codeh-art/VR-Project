﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotted : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

    }
}
