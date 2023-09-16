using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Cube : MonoBehaviour
{
    [SerializeField] public GameObject objeto;
    [SerializeField] public Numero_ScriptObj numeroScriptObj;
    //[SerializeField] private int cant;
    
    // Start is called before the first frame update
    void Start()
    {
        
        for (var i = 1; i < numeroScriptObj.numero ; i++)
        {
            Instantiate(objeto, new Vector3(Random.Range(0f, 8f), Random.Range(0f, 8f), Random.Range(0f, 8f)), Quaternion.identity);
        }
        // Vector3 posicion = new Vector3(Random.Range(0f, 8f), Random.Range(0f, 8f), Random.Range(0f, 8f));
        // Instantiate(objeto, posicion, Quaternion.identity);
        
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
