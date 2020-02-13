using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
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
       
            GameObject effect =  Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        Destroy(gameObject);
    }



    private void OnTriggerEnter2D(Collider2D other)  //เอเฟคระเบิดเมื่อโดนcollider enemy
    {
        if(other.tag == "Enemy")
        {
            Score.scoreValue += 1;
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);

            Destroy(other.gameObject);
        }
        if (other.tag == "BomberBot")
        {
            Score.scoreValue += 1;
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);

            Destroy(other.gameObject);
        }
    }

}
