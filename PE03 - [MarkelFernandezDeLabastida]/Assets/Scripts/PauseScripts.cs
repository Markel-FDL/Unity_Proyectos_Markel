using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScripts : MonoBehaviour
{
    
    public void Setup()
    {
        gameObject.SetActive(true);
    }
    
    public void VolverJuego()
    {
        Time.timeScale = 1;
        StartCoroutine(Wait());
        gameObject.SetActive(false);
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
