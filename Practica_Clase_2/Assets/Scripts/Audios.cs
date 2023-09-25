using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Audios : MonoBehaviour
{
    private AudioSource[] audios = new AudioSource[3];
    // Start is called before the first frame update
    void Start()
    {
        audios.Append(Resources.Load("Music/02. Risk of Rain 2"));
        audios.Append(Resources.Load("Music/bakemonogatari Ost 23 Kotoba no Bouryoku"));
        audios.Append(Resources.Load("Music/Guilty Gear 2 Overture - Diva (Valentine\u00b4s Final Form theme Boss) - OST"));
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audios[0].Play();
        }
    }
}
