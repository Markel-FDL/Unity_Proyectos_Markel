using System;
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
        var json = PlayerPrefs.GetString("Puntuacion", "{}");
        sd = new ScoreData();
    }

    public IEnumerable<Score> GetHighScores()
    {
        return ScoreData.scores.OrderByDescending(x => x.puntuacion);
    }

    // public void AddScore(Score puntuacion)
    // {
    //     sd.scores.Add(puntuacion);
    // }

    private void OnDestroy()
    {
        SaveScore();
    }

    public void SaveScore()
    {
        var json = JsonUtility.ToJson(sd);
        PlayerPrefs.SetString("Puntuacion", json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
