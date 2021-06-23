using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    void Awake()
    {
        ScoreManager.GetInstance().GetScore();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ScoreManager.GetInstance().AddScore(5);
            Debug.Log(ScoreManager.GetInstance().GetScore());
        }
    }
}
