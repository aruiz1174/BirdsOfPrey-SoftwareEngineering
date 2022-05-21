using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Bird : MonoBehaviour
{
    public int health = 150;
    private Vector2 birdStart;
    [SerializeField] private int speed = 400;
    [SerializeField] private int diameter = 3;

    void Start()
    {
        birdStart = GetComponent<Rigidbody2D>().position;

        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    void OnMouseDrag()
    {
        Vector3 followMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 birdDrag = followMouse;
       
        double distance = Vector2.Distance(birdDrag, birdStart);
        if (distance > diameter)
        {
            Vector2 direction = birdDrag - birdStart;
            direction.Normalize();
            birdDrag = (direction * diameter) + birdStart;
        }

        if (birdDrag.x > birdStart.x)
        {
            birdDrag.x = birdStart.x;
        }
        GetComponent<Rigidbody2D>().position = birdDrag;
    }

    void OnMouseUp()
    {
        Vector2 birdPosition = GetComponent<Rigidbody2D>().position;
        Vector2 birdLaunch = birdStart - birdPosition;
        birdLaunch.Normalize();

        GetComponent<SpriteRenderer>().color = Color.white;
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Rigidbody2D>().AddForce(birdLaunch * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(birdRespawn());
    }

    IEnumerator birdRespawn()
    {
        yield return new WaitForSeconds(3);

        GetComponent<Rigidbody2D>().position = birdStart;

        GetComponent<Rigidbody2D>().isKinematic = true;

        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
