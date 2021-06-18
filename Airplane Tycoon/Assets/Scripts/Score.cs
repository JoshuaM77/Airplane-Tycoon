using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using UnityEngine.UI;


public class Score : MonoBehaviour
{
   
    public Text scoreDisplay;
    public bool resetScore = false;

   
    private static int scoreValue;


    void Start()
    {
      
        if (resetScore)
        {
            
            scoreValue = 0;
        }

      
        scoreDisplay.text = scoreValue.ToString();
    }


    public void AddScore(int toAdd)
    {
       
        scoreValue = scoreValue + toAdd;

       
        scoreDisplay.text = scoreValue.ToString();
    }

    




}
