using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float forceStrength;





    public void MoveUp()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();


        ourRigidbody.AddForce(Vector2.up * forceStrength);
    }

    public void MoveDown()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.down * forceStrength);

    }

    public void MoveLeft()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.left * forceStrength);
    }

    public void MoveRight()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.right * forceStrength);
    }

    void Update()
    {
        
        if(transform.position.y >= 255)
        {
            transform.position = new Vector3(transform.position.x, 255, 0);

        }
        else if(transform.position.y <= 15)
        {
            transform.position = new Vector3(transform.position.x, 15, 0);
        }

        if (transform.position.x >= 418)
        {
            transform.position = new Vector3(418, transform.position.y ,0);

        }
        else if (transform.position.x <= -26)
        {

            transform.position = new Vector3(-26, transform.position.y, 0);
        }

    }
}

    

   

    
