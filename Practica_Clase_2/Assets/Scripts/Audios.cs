using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Audios : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios = new AudioClip[3];

    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update

    [SerializeField] private bool activo = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // audios.Append(Resources.Load("Music/02. Risk of Rain 2"));
        // audios.Append(Resources.Load("Music/bakemonogatari Ost 23 Kotoba no Bouryoku"));
        // audios.Append(Resources.Load("Music/Guilty Gear 2 Overture - Diva (Valentine\u00b4s Final Form theme Boss) - OST"));
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !audioSource.isPlaying)
        {
            ClickIzquierdo();
            
        }else if (Input.GetMouseButtonDown(1))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.UnPause();
            }
        } else if (Input.GetMouseButtonDown(2))
        {
                audioSource.Stop();
                activo = false;
        }
        
        
    }

    void ClickIzquierdo()
    {
        if (!activo)
        {
            audioSource.clip = audios[Random.Range(0, audios.Length)];
            audioSource.Play();
            activo = true;
            Debug.Log(audios.Length);
        }
        
        
    }
}
