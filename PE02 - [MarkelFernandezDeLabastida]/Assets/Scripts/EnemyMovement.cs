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
    [SerializeField] private float _fuerza = 200f;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    [SerializeField]private Vector2 direccion;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        //transform.position = new Vector2(7f, -3f);
        _rigidbody2D.AddForce(new Vector2(Random.Range(8f, 15f), Random.Range(8f, 15f)) * _fuerza);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     transform.position = Vector2.MoveTowards(transform.position, direccion, velocidad);
    // }

    private void FixedUpdate()
    {
        
        {
            
          //  FijarNuevoDestino();
        }
    }
    
    
}

// transform.position = Vector2.MoveTowards(transform.position, direccion, velocidad);
// if (Vector2.Distance(transform.position, direccion) < rango)

// void FijarNuevoDestino()
// {
//     direccion = new Vector2(Random.Range(-distancia_Maxima, distancia_Maxima),
//         Random.Range(-distancia_Maxima, distancia_Maxima));
// }