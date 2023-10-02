using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over_Script : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void SalirJuego()
    {
        #if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;
        
        #else
        Application.Quit();
        Debug.Log("Salir");

        #endif
    }
}
