using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Transform target; // เก็บค่าตัวtarget
    float speed = 5; // เก็บค่า speed
    Rigidbody2D rb; // ประกาศใช้ Rigibody2D
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 targetPosition = target.position; 
        Vector2 botPosition = transform.position;
        Vector2 direction = targetPosition - botPosition;
        direction.y = 0;


        rb.velocity = direction.normalized * speed;


	}
}
