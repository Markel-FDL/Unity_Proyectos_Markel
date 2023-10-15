using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn_enemies : MonoBehaviour
{
    [SerializeField] private GameObject objeto;
    [SerializeField] private GameObject powerUp;

    [SerializeField] private GameObject vida;
    // Start is called before the first frame update
    // Spawnea tres enemigos y un PowerUp en posiciones fijas del mapa.
    void Start()
    {
        Instantiate(objeto, new Vector3(7f, -3), quaternion.identity);
        Instantiate(objeto, new Vector3(-7f, 3f), quaternion.identity);
        Instantiate(objeto, new Vector3(-6f, 0f), quaternion.identity);
        Instantiate(powerUp, new Vector3(Random.Range(-7f, 7f), -3), quaternion.identity);
        Instantiate(vida, new Vector3(6f, -2f), quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
