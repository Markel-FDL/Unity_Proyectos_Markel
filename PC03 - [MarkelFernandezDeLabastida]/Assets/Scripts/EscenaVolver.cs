using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaVolver: MonoBehaviour
{
    public string escena = "SampleScene";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaPrincipal()
    {
        SceneManager.LoadScene(escena);
    }
}
