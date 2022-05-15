using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score = 0;
    void Start()
    {
        if(instance == null){
            instance= this;
        }
    }

    public void ChangeScore(int coinValue){
        // score ++;
        // print("coinvalue");
        // print(coinValue);
        score = score + coinValue;
        // print("Score");
        // print(score);
        text.text = "X" + score.ToString();
        // text.text = "X" +  ;
    }
}
