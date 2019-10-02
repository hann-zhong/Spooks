using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookSpawn : MonoBehaviour
{
    public GameObject spookPrefab;
    float randomX, randomY;
    Vector2 spawnLoc;
    public float rate = 2f;
    float nextSpawn = 1f;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        if((target != null) && (nextSpawn < Time.time))
        {
            nextSpawn = Time.time + rate;
            randomX = Random.Range(-7, 7);
            randomY = Random.Range(-2, 2);
            spawnLoc = new Vector2(randomX * 3, randomY * 3);
            Instantiate(spookPrefab, spawnLoc, Quaternion.identity);
            
        }
    }
}
