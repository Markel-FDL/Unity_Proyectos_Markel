using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Vector3 posicionRaton;
    [SerializeField] private Rigidbody2D RigidBody;
    [SerializeField] private BoxCollider2D _collider2D;
    [SerializeField] private SpriteRenderer _renderer2D;
    [SerializeField] private Vector2 direccion;
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private int vidas;
    [SerializeField] private Game_Over_Script gameOver;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // 
        RigidBody = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<BoxCollider2D>();
        _renderer2D = GetComponent<SpriteRenderer>();
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
        if (enemigo.gameObject.CompareTag("Enemy") && vidas > 1)
        {
            vidas--;
            Debug.Log(vidas);
            StartCoroutine("Invencible");

        } else if (enemigo.gameObject.CompareTag("Enemy") && vidas == 1)
        {
            gameOver.Setup();
        }
        
    }

    IEnumerator Invencible()
    {
        Physics2D.IgnoreLayerCollision(3, 6, true);
        _renderer2D.color = Color.gray;
        yield return new WaitForSeconds(1f);
        Physics2D.IgnoreLayerCollision(3, 6, false);
        _renderer2D.color = Color.white;

    }
}

//gameOver.Setup();
// Destroy(enemigo.gameObject);
// Application.Quit();