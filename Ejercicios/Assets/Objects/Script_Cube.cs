using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Cube : MonoBehaviour
{
    public GameObject objeto;
    public Numero_ScriptObj numeroScriptObj;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(objeto);
        }
        
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
