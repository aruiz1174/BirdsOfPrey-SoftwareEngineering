using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    bool crateDrop;

    void Start()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }


    private bool BirdCollision(Collision2D collision)
    {
        if (crateDrop)
        {
            return false;
        }

        Red_Bird redBird = collision.gameObject.GetComponent<Red_Bird>();

        if (redBird != null)

            return true;

        if (collision.contacts[0].normal.y < -0.01)

            return true;

        else

            return false;
    }

    void Destroy()
    {
        crateDrop = true;
        GetComponent<Rigidbody2D>().isKinematic = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (BirdCollision(collision))
        {
            Destroy();
        }
    }
}