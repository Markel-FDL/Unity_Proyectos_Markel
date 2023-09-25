using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float rango;
    [SerializeField] private float distancia_Maxima;

    [SerializeField]private Vector2 direccion;
    // Start is called before the first frame update
    void Start()
    {
        
        FijarNuevoDestino();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     transform.position = Vector2.MoveTowards(transform.position, direccion, velocidad);
    // }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, direccion, velocidad);
        if (Vector2.Distance(transform.position, direccion) < rango)
        {
            FijarNuevoDestino();
        }
    }
    
    void FijarNuevoDestino()
    {
        direccion = new Vector2(Random.Range(-distancia_Maxima, distancia_Maxima),
            Random.Range(-distancia_Maxima, distancia_Maxima));
    }
}
