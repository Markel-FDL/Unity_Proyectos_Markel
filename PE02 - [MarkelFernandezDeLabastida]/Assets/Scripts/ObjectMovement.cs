using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Vector3 posicionRaton;
    [SerializeField] private Rigidbody2D RigidBody;
    [SerializeField] private BoxCollider2D _collider2D;
    [SerializeField] private SpriteRenderer _renderer2D;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Vector2 direccion;
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private AudioClip[] clip = new AudioClip[2];
    [SerializeField] public int vidas;
    [SerializeField] private Game_Over_Script gameOver;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // 
        RigidBody = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
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

    // Cuando el jugador choque con el power up, sonará el audio de PowerUp y ejecutará el coroutine donde 
    // reduce el tamaño del jugador durante 5 segundos
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            _audioSource.clip = clip[2];
            _audioSource.Play();
            StartCoroutine(PowerUp());
            Destroy(other.gameObject);
        }
        
    }

    IEnumerator PowerUp()
    {
        transform.localScale = new Vector2(0.25f, 0.25f);
        yield return new WaitForSeconds(5f);
        transform.localScale = new Vector2(0.5f, 0.5f);
    }
    
    // Cuando el jugador choque con el enemigo, sonará el clip de hitmarker y reducira la vida en 1 lanzando 
    // un coroutine haciendo al jugador invencible durante 1 segundo.
    private void OnCollisionEnter2D(Collision2D enemigo)
    {
        if (enemigo.gameObject.CompareTag("Enemy") && vidas > 1)
        {
            _audioSource.clip = clip[0];
            _audioSource.Play();
            _audioSource.loop = false;
            vidas--;
            Debug.Log(vidas);
            StartCoroutine("Invencible");

        } else if (enemigo.gameObject.CompareTag("Enemy") && vidas == 1)
        {
            _audioSource.clip = clip[1];
            _audioSource.Play();
            Time.timeScale = 0;
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