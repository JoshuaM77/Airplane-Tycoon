using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyLocation : MonoBehaviour
{
    // Start is called before the first frame update

    public int Location = 0;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Plane") ;
        {
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
