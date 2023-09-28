using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UI_Script : MonoBehaviour
{
    [SerializeField] private Escena1 Escena1;
    [SerializeField] private Escena1 Escena2;
    [SerializeField] private Escena1 Escena3;
    [SerializeField] private Escena1 Escena4;

    public string NombreEscena1 = "Escena1";
    public string NombreEscena2 = "Escena2";
    public string NombreEscena3 = "Escena3";
    public string NombreEscena4 = "Escena4";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscena1()
    {
        SceneManager.LoadScene(NombreEscena1);
    }
    
    public void CambiarEscena2()
    {
        SceneManager.LoadScene(NombreEscena2);
    }
    
    public void CambiarEscena3()
    {
        SceneManager.LoadScene(NombreEscena3);
    }
    
    public void CambiarEscena4()
    {
        SceneManager.LoadScene(NombreEscena4);
    }
}
