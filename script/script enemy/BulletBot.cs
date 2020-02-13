using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBot : MonoBehaviour
{

    public GameObject hitEffect;
    public float speed;
    private Transform player;
    private Vector2 target;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            shot();
        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)  // ตัวนี้ๆ เมื่อ bullet ชน collider เกิดการระเบิด
    {

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        Destroy(gameObject);



    }

    private void OnTriggerEnter2D(Collider2D other)  
    {
        if (other.tag == "Player")
        {

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);

          //Destroy(other.gameObject);
        }
    }



    void shot()
    {
        Destroy(gameObject);
    }

    
}
