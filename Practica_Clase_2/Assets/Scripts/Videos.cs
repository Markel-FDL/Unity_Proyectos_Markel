using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Videos : MonoBehaviour
{
    [SerializeField] private VideoClip[] videos = new VideoClip[3];

    [SerializeField] private VideoPlayer player;
    
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
                if (hit.collider == gameObject.CompareTag("Play"))
                {
                    Debug.Log("Uno");
                    player.clip = videos[Random.Range(0, videos.Length)];
                    player.Play();
                }else if (hit.collider == gameObject.CompareTag("Pause"))
                {
                    Debug.Log("Dos");
                }else if (hit.collider == gameObject.CompareTag("Stop"))
                {
                    Debug.Log("tres");
                }
                
                Debug.Log(hit.transform);
            }
        }
    }
}
