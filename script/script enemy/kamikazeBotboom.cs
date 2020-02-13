using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamikazeBotboom : MonoBehaviour
{


    public float speed;

    public GameObject hitEffect;
    private Transform player;
    public float stoppingDistance;
    public float retreatDistance;
    public float startTimeBtwShots;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        
        if (Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);

            // Destroy(other.gameObject);
        }
    }



}
