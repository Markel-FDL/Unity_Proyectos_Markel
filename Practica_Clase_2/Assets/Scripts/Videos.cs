using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Videos : MonoBehaviour
{
    [SerializeField] private VideoClip[] videos = new VideoClip[3];

    [SerializeField] private VideoPlayer player;

    private int numeroVideo = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.zero); 
            if (hit.collider != null)
            {
                if (hit.collider.name == "Play")
                {
                    Debug.Log("Play");
                    
                    int numero = Random.Range(0, videos.Length);
                    while (numero == numeroVideo)
                    {
                        numero = Random.Range(0, videos.Length);
                    }

                    numeroVideo = numero;
                    player.clip = videos[numero];
                    player.Play();
                }else if ((hit.collider.name == "Pause" && player.isPlaying))
                {

                    player.Pause();
                    Debug.Log("pause");

                }else if ((hit.collider.name == "Pause" && player.isPaused))
                {
                    player.Play();
                    
                }else if ((hit.collider.name == "Stop" && player.isPlaying) || (hit.collider.name == "Stop" && player.isPaused))
                {
                    player.Stop();
                    Debug.Log("tres");
                }
                
                Debug.Log(hit.collider.name);
                // player.clip = videos[Random.Range(0, videos.Length)];
                // player.Play();
            }
        }
    }
}
