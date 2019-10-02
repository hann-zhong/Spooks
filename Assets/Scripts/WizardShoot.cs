using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardShoot : MonoBehaviour
{
    public Transform point;
    public GameObject firePrefab;
    public float fireForce = 20f;

    // Update is called once per frame
    void Update()
    {
        //Shoot fireball when mouse is clicked
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject fireball =  Instantiate(firePrefab, point.position, point.rotation);
        Rigidbody2D rb = fireball.GetComponent<Rigidbody2D>();
        rb.AddForce(point.up * fireForce, ForceMode2D.Impulse);
    }
}
