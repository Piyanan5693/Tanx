﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float buttetFore = 20f;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }

    }
    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up* buttetFore,ForceMode2D.Impulse);
    }
}
