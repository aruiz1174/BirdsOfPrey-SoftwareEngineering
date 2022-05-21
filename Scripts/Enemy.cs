using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem destroyEffect;
    [SerializeField] Sprite destroyed;
    bool enemyDead;

    private bool BirdCollision(Collision2D collision)
    {
        if (enemyDead)
        {
            return false;
        }

        Red_Bird redBird = collision.gameObject.GetComponent<Red_Bird>();

        if (redBird != null)
            
                return true;
            
        if (collision.contacts[0].normal.y < -0.25)
            
                return true;
            
        else

                return false;
            
    }

    IEnumerator Destroy()
    {
        enemyDead = true;
        GetComponent<SpriteRenderer>().sprite = destroyed;
        destroyEffect.Play();
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (BirdCollision(collision))
        {
            StartCoroutine(Destroy());
        }
    }
}
