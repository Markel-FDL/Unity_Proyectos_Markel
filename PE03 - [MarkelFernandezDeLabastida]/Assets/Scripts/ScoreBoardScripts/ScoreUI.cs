using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    public ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager.AddScore(new Score((int)StateNameScript.tiempo));
        
        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
            row.posicion.text = (i + 1).ToString();
            row.puntuacion.text = scores[i].puntuacion.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
