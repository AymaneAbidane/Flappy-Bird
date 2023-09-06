using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] TMP_Text highScoreTxT;
    void Start()
    {
        int highScore = PlayerPrefs.GetInt(ScoreHandler.highScoreKey, 0);
        highScoreTxT.text = "High Score: " + highScore.ToString();
         
        GetComponent<AudioSource>().Play();
    }


}
