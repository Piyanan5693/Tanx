using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [Header("Stats")]
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float startTimeBtwShots;
    private float timeBtwShot;

    [Header("References")]
    public GameObject shot;
    private Transform player;








    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShot = startTimeBtwShots;
    }
    void Update()
    {

        //if(Vector2.Distance(transform.position,player.position) > retreatDistance)
        //{
        //     transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        // }else if (Vector2.Distance(transform.position,player.position)<stoppingDistance)
        // {
        // transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        // }else if(Vector2.Distance(transform.position, player.position)< stoppingDistance && Vector2.Distance(transform.position,player.position)> retreatDistance)
        // {
        // transform.position = this.transform.position;
        //}


        if (Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);


            // Enemy shoot
            if (timeBtwShot <= 0)
            {
                Instantiate(shot, transform.position, Quaternion.identity);
                timeBtwShot = startTimeBtwShots;
            }
            else
            {
                timeBtwShot -= Time.deltaTime;
            }
        }


    }
}





    