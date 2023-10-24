using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscena(String escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void ReiniciarJuego(String escena)
    {
        SceneManager.LoadSceneAsync(escena);
    }

    public void VolverJuego()
    {
        Time.timeScale = 1;
        
    }

    public void Salir()
    {
        Application.Quit();
    }
}
