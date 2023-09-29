using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Vector3 posicionRaton;
    [SerializeField] private Rigidbody2D RigidBody;
    [SerializeField] private Vector2 direccion;
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Game_Over_Script gameOver;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // 
        RigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Recoge la posición del raton en el mundo, no en pixels
        posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Mueve entre puntos
        direccion = Vector2.Lerp(transform.position, posicionRaton, velocidadMovimiento);
        
        
    }

    private void FixedUpdate()
    {
        RigidBody.MovePosition(direccion);
    }

    private void OnCollisionEnter2D(Collision2D enemigo)
    {
        if (enemigo.gameObject.CompareTag("Enemy"))
        {
            gameOver.Setup();
            // Destroy(enemigo.gameObject);
            // Application.Quit();
        }
    }
}
