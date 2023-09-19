using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Linea para usar este ScriptableObject como blueprint en un GameObject.
[CreateAssetMenu(fileName = "N Veces", menuName = "Cantidad")]
public class Numero_ScriptObj : ScriptableObject
{
    // Cantidad de Prefaps clonados
    [SerializeField] public int cantidadObjetos;
}
