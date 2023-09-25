using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn_enemies : MonoBehaviour
{
    [SerializeField] private GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objeto, new Vector3(Random.Range(2f, 6f), Random.Range(2f, 6f), 0), quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
