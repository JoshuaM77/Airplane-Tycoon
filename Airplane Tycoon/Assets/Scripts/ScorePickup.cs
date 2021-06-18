using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{

    
    public int pickupValue = 1;


   
    void OnTriggerEnter2D(Collider2D other)
    {
      
        Score scoreScript = other.GetComponent<Score>();

       
        if (scoreScript != null)
        {
          

            
            scoreScript.AddScore(pickupValue);

            
            Destroy(gameObject);
        }
    }
}
