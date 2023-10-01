using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VidasScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _texto_vidas;
    //[SerializeField] private TextMeshProUGUI _tiempo;

    [SerializeField] private ObjectMovement objectMovement;

    // Start is called before the first frame update
    void Start()
    {
        _texto_vidas = GetComponent<TextMeshProUGUI>();
        //_tiempo = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _texto_vidas.text = "Vidas: " + objectMovement.vidas.ToString();
        
        //_tiempo.text += Time.deltaTime.ToString();
    }

    // private void OnCollisionEnter2D(Collision2D enemigo)
    // {
    //     if (enemigo.gameObject.CompareTag("Enemy") && objectMovement.vidas > 1)
    //     {
    //         //Debug.Log(vidas);
    //
    //         _texto_vidas.text = "Vidas: " + objectMovement.vidas;
    //     }
    // }
}