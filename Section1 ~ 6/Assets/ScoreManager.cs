using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager GetInstance()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<ScoreManager>();

            if(instance == null)
            {
                GameObject container = new GameObject("ScoreManager");
                container.AddComponent<ScoreManager>();
            }
        }
        return instance;
    }
    
    void Start()
    {
        if(instance != null)
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
    private int score = 0;
    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }
}
