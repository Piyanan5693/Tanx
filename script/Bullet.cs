using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour  // bullet ตอนplayer คลิกยิง
{
    public GameObject hitEffect; 
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter2D(Collision2D collision)   // เอเฟคระเบิดเมื่อโดนcollider อื่น
    {
       
            GameObject effect =  Instantiate(hitEffect, transform.position, Quaternion.identity); // gameobject = hitEffect 
        Destroy(effect, 5f);

        Destroy(gameObject);
    }



    private void OnTriggerEnter2D(Collider2D other)  //เอเฟคระเบิดเมื่อโดนcollider enemy
    {
        if(other.tag == "Enemy") // เมื่อชนกับtag enemy score +1 และแสดงeffect แล้วทำลายทิ้ง
        {
            Score.scoreValue += 1;
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);

            Destroy(other.gameObject);
        }
        if (other.tag == "BomberBot") // เมื่อชนกับtag bommerbot score +1 และแสดงeffect แล้วทำลายทิ้ง
        {
            Score.scoreValue += 1;
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);

            Destroy(other.gameObject);
        }
    }

}
