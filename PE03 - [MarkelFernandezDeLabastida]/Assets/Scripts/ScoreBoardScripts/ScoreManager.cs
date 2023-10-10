using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private ScoreData sd;
    
    
    
    // Start is called before the first frame update
    void Awake()
    {
        sd = new ScoreData();
    }

    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderByDescending(x => x.puntuacion);
    }

    public void AddScore(Score puntuacion)
    {
        sd.scores.Add(puntuacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
