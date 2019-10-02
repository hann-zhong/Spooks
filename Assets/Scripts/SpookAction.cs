using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookAction : MonoBehaviour
{
    public float speed = 1f;
    private Transform target;

    void Start()
    {
        //Wizard is tagged as player in Unity, then set as the target
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        //Spooks move towards position of the target
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}

