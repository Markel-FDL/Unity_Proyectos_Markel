using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Cube : MonoBehaviour
{
    [SerializeField] public GameObject objeto;
    [SerializeField] public Numero_ScriptObj cantidadCubos;
    //[SerializeField] private int cant;
    
    // Start is called before the first frame update
    void Start()
    {
        // Spawnea la cantidad de prefabs indicada en el ScriptableObject de forma aleatoria.
        for (var i = 0; i < cantidadCubos.cantidadObjetos ; i++)
        {
            Instantiate(objeto, new Vector3(Random.Range(0f, 8f), Random.Range(0f, 8f), Random.Range(0f, 8f)), Quaternion.identity);
        }
        
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
