using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
   // Rigidbody2D rb;
   // GameObject target;
   // float moveSpeed;
   // float driectionTarget;
   // public GameObject HitEffect;
	// Use this for initialization
	void Start ()
    {
       // target = GameObject.Find("Player");
       // rb = GetComponent<Rigidbody2D>();
       // moveSpeed = Random.Range(1f, 3f);
	}
	
	// Update is called once per frame
	void Update ()
    {
       // MoveEnemy();
	}
   // private void OnTriggerEnter2D(Collider2D col)
   // {
        //switch (col.gameObject.tag)
        //{
           // case "Tanx":
          //
                //SpawnEnemy.spawnAllowed = false;
               // Instantiate(HitEffect, col.gameObject.transform.position, Quaternion.identity);

          //  case "Bullet":
          //
               // SpawnEnemy.spawnAllowed = false;
               // Instantiate(HitEffect, col.gameObject.transform.position, Quaternion.identity);
              //  Destroy(col.gameObject);
               // Destroy(gameObject);
               // break;
        //}


        //GameObject effect = Instantiate(HitEffect);
      //  Destroy(effect, 5f);

       // Destroy(gameObject);
    //}

    //void MoveEnemy()
    //{
       // if (target != null)
       // { 
            // driectionTarget = (target.transform.position - transform.position).normalized;
          ////// // rb.velocity = driectionTarget.normalized *moveSpeed;
            //rb.velocity = new Vector2(driectionTarget.x * moveSpeed, driectionTarget.y * moveSpeed);
       // }
       // else rb.velocity = Vector2.zero;
   // }
}
