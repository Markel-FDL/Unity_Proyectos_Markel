using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public ScoreData sd;
    
    
    
    // Start is called before the first frame update
    void Awake()
    {
        var json = PlayerPrefs.GetString("Puntuacion", "{}");
        sd = JsonUtility.FromJson<ScoreData>(json);
    }

    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderByDescending(x => x.puntuacion);
    }

    public void AddScore(Score puntuacion)
    {
        sd.scores.Add(puntuacion);
    }

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
