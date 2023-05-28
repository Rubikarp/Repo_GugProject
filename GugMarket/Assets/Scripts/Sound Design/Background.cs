using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public AudioSource Music;

    private void Awake()
    {
        if (Music == null)
        {
            DontDestroyOnLoad(Music.gameObject);
        }
    }
}
