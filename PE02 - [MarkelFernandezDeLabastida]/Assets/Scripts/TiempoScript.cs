using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TiempoScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textoTiempo;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        _textoTiempo = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        _textoTiempo.text = "Tiempo: " + (Mathf.Round(tiempo * 100 / 100)).ToString();
    }
}
