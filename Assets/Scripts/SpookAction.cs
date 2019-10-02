﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookAction : MonoBehaviour
{
    public float speed = 1f;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}

