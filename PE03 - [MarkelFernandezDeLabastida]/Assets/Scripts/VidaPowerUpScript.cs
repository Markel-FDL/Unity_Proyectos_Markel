using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPowerUpScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _fuerza = 20f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(new Vector2(Random.Range(8f, 15f), Random.Range(8f, 15f)) * _fuerza);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
