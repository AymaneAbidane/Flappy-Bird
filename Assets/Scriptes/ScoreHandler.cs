using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    int score=0;

    public const string highScoreKey = "HighScore";

    [SerializeField] TextMeshProUGUI scoreTxT;

    [SerializeField] AudioClip scoreSound;
    // Update is called once per frame
    void Update()
    {
        scoreTxT.text=score.ToString();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ScorePoint")
        {
            score++;
            GetComponent<AudioSource>().PlayOneShot(scoreSound);
        }
    }

    void OnDestroy()
    {
        int currentPlayerHighScore = PlayerPrefs.GetInt(highScoreKey, 0); 

        if (score > currentPlayerHighScore) 
        {
            PlayerPrefs.SetInt(highScoreKey, Mathf.FloorToInt(score));
            Debug.Log(currentPlayerHighScore);
        }


    }
}

