using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    //public Text timeText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + PlayerStats.Score;
        /*float f = Time.time;
        float fc = (float)Mathf.Round(f) / 1f;
        timeText.text = fc+"";*/

    }

}
