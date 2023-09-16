using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "N Veces", menuName = "Cantidad")]
public class Numero_ScriptObj : ScriptableObject
{
    [SerializeField] public int numero;
}
