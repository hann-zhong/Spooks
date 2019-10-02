using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRxn : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreCounter.scoreVal += 10;
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}


