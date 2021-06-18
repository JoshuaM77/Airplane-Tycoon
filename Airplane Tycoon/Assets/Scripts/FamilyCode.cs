using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyCode : MonoBehaviour
{
    // Start is called before the first frame update

    public int Location = 0;

    public int pickupValue = 1;

   


    // Called by Unity when this object overlaps with another object
    // This is our Condition
    void OnTriggerEnter2D(Collider2D other)
    {
        // Get the Score script attached to the other object
        // (if it doesn't have one, scoreScript will be null)
        Score scoreScript = other.GetComponent<Score>();

        // Check if we actually found a Score script on the other object
        if (scoreScript != null)
        {
            // We have a scorescript, so the thing we bumped into is the player!

            // We should add to their score now:
            scoreScript.AddScore(pickupValue);

            // Then we should delete this object, so we don't add again next frame!

            NextLocation();
            
        }
    }





    public void NextLocation()
    {
        Location = Random.Range(1, 6);

        if (Location == 1)
        {
            transform.position = new Vector3(22, 235, 0);

        }

        if (Location == 2)
        {
            transform.position = new Vector3(231, 249, 0);

        }

        if (Location == 3)
        {
            transform.position = new Vector3(324, 184, 0);

        }

        if (Location == 4)
        {
            transform.position = new Vector3(177, 131, 0);

        }

        if (Location == 5)
        {
            transform.position = new Vector3(364, 29, 0);

        }

        if (Location == 6)
        {
            transform.position = new Vector3(29, 25, 0);

        }



    }









}

